using SiusData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SiusDataHelper
{
   public partial class MainForm : Form
   {
      readonly StartListFile StartListFile;
      private Dictionary<string, string[]> ShotValues = new Dictionary<string, string[]>();

      public MainForm()
      {
         InitializeComponent();

         var basePath = ConfigurationManager.AppSettings["SiusData"];

         var stlFiles = Directory.GetFiles(basePath, "*_stl.csv");

         if (stlFiles.Length != 1)
         {
            MessageBox.Show(
               $"Found {stlFiles.Length} stl files in '{basePath}'. Expected 1",
               "Error",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
         }
         else
         {
            StartListFile = SiusParser.ParseStartList(stlFiles[0]);

            toolStripStatusLabel1.Text = StartListFile.FileName;

            foreach (var shooter in StartListFile.Shooters)
            {
               listBoxShooters.Items.Add(shooter.SCBDName);
            }

            listBoxShooters.SelectedIndex = 0;
         }

      }

      private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
      {
         MessageBox.Show("SIUS Data Helper - Kristiansand Pistolskyttere", "About", MessageBoxButtons.OK);
      }

      private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
      {
         Application.Exit();
      }

      private void generateToolStripMenuItem_Click(object sender, System.EventArgs e)
      {
         if (MessageBox.Show("Generate data file?", "Q?", MessageBoxButtons.OKCancel) == DialogResult.OK)
         {
            var shotDataFile = new ShotDataFile
            {
               FileName = StartListFile.FileName.Replace("_stl", ""),
               Shots = new List<ShotData>()
            };

            if (File.Exists(shotDataFile.FileName))
               File.Delete(shotDataFile.FileName);

            foreach (var shooter in StartListFile.Shooters)
            {
               if (!ShotValues.ContainsKey(shooter.SCBDName))
                  continue;

               var allShots = ShotValues[shooter.SCBDName]
                  .SelectMany(x => x)
                  .ToList();

               for (int i = 0; i < allShots.Count; i++)
               {
                  var ch = allShots[i];

                  shotDataFile.Shots.Add(new ShotData()
                  {
                     StartNR = shooter.StNr,
                     Demonstration = "0",
                     ExternalNumber = "0",
                     Firekind = "1",
                     Group = shooter.Group,
                     Innerten = ch == 'O' ? "1" : "0",
                     InsDel = "0",
                     Divisions = "0",
                     Firingpoint = shooter.Target,
                     Intime = "1",
                     Logevent = "0",
                     Logtype = "3",
                     Position = "0",
                     TargetID = "0",
                     TimeSinceChange = "0.01",
                     Totalkind = "0",
                     Weapon = "0",
                     X = "0",
                     Y = "0",
                     MatchShot = "1",
                     PrimaryScore = $"{ShotValue(ch)}",
                     Relay = shooter.Relay,
                     SecondaryScore = $"{ShotValue(ch)}",
                     Shoot = i.ToString(),
                     SweepDirection = "0",
                     Time = DateTime.Now.ToString("HH:mm:ss"),
                     Practice = "0",
                     TimeSinceBeginningOfTheCurrentYear = "0"
                  });
               }

            }

            var writer = new ShotDataFileWriter();
            writer.Write(shotDataFile);
         }
      }

      private void buttonSaveScore_Click(object sender, System.EventArgs e)
      {
         var scbdName = (string)listBoxShooters.SelectedItem;

         ShotValues[scbdName] = new string[] {
            textBoxScore1.Text,
            textBoxScore2.Text,
            textBoxScore3.Text,
            textBoxScore4.Text,
            textBoxScore5.Text,
            textBoxScore6.Text
         };
      }

      private void listBoxShooters_SelectedIndexChanged(object sender, System.EventArgs e)
      {
         var scbdName = (string)listBoxShooters.SelectedItem;

         var NullShot = new string[] {
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty
         };

         Shooter NullShooter = new Shooter();

         var selectedShooter = StartListFile.Shooters.FirstOrDefault(
            s => s.SCBDName == scbdName) ?? NullShooter;

         string[] shots = NullShot;

         if (ShotValues.ContainsKey(scbdName))
         {
            shots = ShotValues[scbdName];
         }

         textBoxScore1.Text = shots[0];
         textBoxScore2.Text = shots[1];
         textBoxScore3.Text = shots[2];
         textBoxScore4.Text = shots[3];
         textBoxScore5.Text = shots[4];
         textBoxScore6.Text = shots[5];

         textBoxFirstName.Text = selectedShooter.Firstname;
         textBoxName.Text = selectedShooter.Name;
         textBoxNat.Text = selectedShooter.NAT;
         textBoxRelay.Text = selectedShooter.Relay;
         textBoxStartTime.Text = selectedShooter.StartTime;
         textBoxStNr.Text = selectedShooter.StNr;
         textBoxTarget.Text = selectedShooter.Target;
         textBoxTeam.Text = selectedShooter.Team;
      }

      private int ShotValue(char ch) {
         if (ch == 'X' || ch == 'O')
            return 10;
         else
            return (ch - '0');
      }

      private string CalculateScore(TextBox tb)
      {
         int result = 0;

         foreach (var ch in tb.Text)
         {
            result += ShotValue(ch);
         }

         return result.ToString();
      }

      private void textBoxScore1_TextChanged(object sender, EventArgs e)
      {
         labelScore1.Text = CalculateScore(textBoxScore1);
      }

      private void textBoxScore2_TextChanged(object sender, EventArgs e)
      {
         labelScore2.Text = CalculateScore(textBoxScore2);
      }

      private void textBoxScore3_TextChanged(object sender, EventArgs e)
      {
         labelScore3.Text = CalculateScore(textBoxScore3);
      }

      private void textBoxScore4_TextChanged(object sender, EventArgs e)
      {
         labelScore4.Text = CalculateScore(textBoxScore4);
      }

      private void textBoxScore5_TextChanged(object sender, EventArgs e)
      {
         labelScore5.Text = CalculateScore(textBoxScore5);
      }

      private void textBoxScore6_TextChanged(object sender, EventArgs e)
      {
         labelScore6.Text = CalculateScore(textBoxScore6);
      }

      private void buttonImport_Click(object sender, EventArgs e)
      {
         var data = Clipboard.GetText();

         if (data == null)
            return;

         var parts = data.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

         if (parts.Length > 0)
            textBoxScore1.Text = parts[0];
         if (parts.Length > 1)
            textBoxScore2.Text = parts[1];
         if (parts.Length > 2)
            textBoxScore3.Text = parts[2];
         if (parts.Length > 3)
            textBoxScore4.Text = parts[3];
         if (parts.Length > 4)
            textBoxScore5.Text = parts[4];
         if (parts.Length > 5)
            textBoxScore6.Text = parts[5];
      }

      private void buttonExport_Click(object sender, EventArgs e)
      {
         var str = new[] {
            textBoxScore1.Text,
            textBoxScore2.Text,
            textBoxScore3.Text,
            textBoxScore4.Text,
            textBoxScore5.Text,
            textBoxScore6.Text
         };

         Clipboard.SetText(string.Join(Environment.NewLine, str));

      }
   }
}