using System.Drawing;
using System.Windows.Forms;

namespace SiusDataHelper
{
   partial class MainForm
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.listBoxShooters = new System.Windows.Forms.ListBox();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.buttonSaveScore = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.label8 = new System.Windows.Forms.Label();
         this.textBoxNat = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.textBoxRelay = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.textBoxName = new System.Windows.Forms.TextBox();
         this.textBoxFirstName = new System.Windows.Forms.TextBox();
         this.textBoxStartTime = new System.Windows.Forms.TextBox();
         this.textBoxTarget = new System.Windows.Forms.TextBox();
         this.textBoxTeam = new System.Windows.Forms.TextBox();
         this.textBoxStNr = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.textBoxScore1 = new System.Windows.Forms.TextBox();
         this.textBoxScore6 = new System.Windows.Forms.TextBox();
         this.textBoxScore5 = new System.Windows.Forms.TextBox();
         this.textBoxScore4 = new System.Windows.Forms.TextBox();
         this.textBoxScore3 = new System.Windows.Forms.TextBox();
         this.textBoxScore2 = new System.Windows.Forms.TextBox();
         this.labelScore1 = new System.Windows.Forms.Label();
         this.labelScore5 = new System.Windows.Forms.Label();
         this.labelScore6 = new System.Windows.Forms.Label();
         this.labelScore4 = new System.Windows.Forms.Label();
         this.labelScore3 = new System.Windows.Forms.Label();
         this.labelScore2 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.buttonImport = new System.Windows.Forms.Button();
         this.buttonExport = new System.Windows.Forms.Button();
         this.statusStrip1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // listBoxShooters
         // 
         this.listBoxShooters.Dock = System.Windows.Forms.DockStyle.Left;
         this.listBoxShooters.FormattingEnabled = true;
         this.listBoxShooters.Location = new System.Drawing.Point(0, 24);
         this.listBoxShooters.Name = "listBoxShooters";
         this.listBoxShooters.Size = new System.Drawing.Size(140, 492);
         this.listBoxShooters.TabIndex = 10;
         this.listBoxShooters.SelectedIndexChanged += new System.EventHandler(this.listBoxShooters_SelectedIndexChanged);
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
         this.statusStrip1.Location = new System.Drawing.Point(0, 516);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(681, 22);
         this.statusStrip1.SizingGrip = false;
         this.statusStrip1.TabIndex = 1;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
         this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(681, 24);
         this.menuStrip1.TabIndex = 2;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // generateToolStripMenuItem
         // 
         this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
         this.generateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
         this.generateToolStripMenuItem.Text = "&Generate";
         this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
         this.exitToolStripMenuItem.Text = "E&xit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.helpToolStripMenuItem.Text = "H&elp";
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
         this.aboutToolStripMenuItem.Text = "&About";
         this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
         // 
         // buttonSaveScore
         // 
         this.buttonSaveScore.Location = new System.Drawing.Point(43, 176);
         this.buttonSaveScore.Name = "buttonSaveScore";
         this.buttonSaveScore.Size = new System.Drawing.Size(75, 23);
         this.buttonSaveScore.TabIndex = 6;
         this.buttonSaveScore.Text = "&Save";
         this.buttonSaveScore.UseVisualStyleBackColor = true;
         this.buttonSaveScore.Click += new System.EventHandler(this.buttonSaveScore_Click);
         // 
         // panel1
         // 
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.label8);
         this.panel1.Controls.Add(this.textBoxNat);
         this.panel1.Controls.Add(this.label7);
         this.panel1.Controls.Add(this.textBoxRelay);
         this.panel1.Controls.Add(this.label6);
         this.panel1.Controls.Add(this.label5);
         this.panel1.Controls.Add(this.label4);
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.textBoxName);
         this.panel1.Controls.Add(this.textBoxFirstName);
         this.panel1.Controls.Add(this.textBoxStartTime);
         this.panel1.Controls.Add(this.textBoxTarget);
         this.panel1.Controls.Add(this.textBoxTeam);
         this.panel1.Controls.Add(this.textBoxStNr);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Location = new System.Drawing.Point(155, 24);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(297, 279);
         this.panel1.TabIndex = 13;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(17, 198);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(29, 13);
         this.label8.TabIndex = 15;
         this.label8.Text = "NAT";
         // 
         // textBoxNat
         // 
         this.textBoxNat.Location = new System.Drawing.Point(82, 195);
         this.textBoxNat.Name = "textBoxNat";
         this.textBoxNat.ReadOnly = true;
         this.textBoxNat.Size = new System.Drawing.Size(188, 20);
         this.textBoxNat.TabIndex = 14;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(13, 172);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(34, 13);
         this.label7.TabIndex = 13;
         this.label7.Text = "Relay";
         // 
         // textBoxRelay
         // 
         this.textBoxRelay.Location = new System.Drawing.Point(82, 169);
         this.textBoxRelay.Name = "textBoxRelay";
         this.textBoxRelay.ReadOnly = true;
         this.textBoxRelay.Size = new System.Drawing.Size(188, 20);
         this.textBoxRelay.TabIndex = 12;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(13, 39);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(35, 13);
         this.label6.TabIndex = 11;
         this.label6.Text = "Name";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(13, 68);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(54, 13);
         this.label5.TabIndex = 10;
         this.label5.Text = "FirstName";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(13, 91);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(34, 13);
         this.label4.TabIndex = 9;
         this.label4.Text = "Team";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(13, 117);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(38, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "Target";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(13, 143);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(55, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Start Time";
         // 
         // textBoxName
         // 
         this.textBoxName.Location = new System.Drawing.Point(82, 39);
         this.textBoxName.Name = "textBoxName";
         this.textBoxName.ReadOnly = true;
         this.textBoxName.Size = new System.Drawing.Size(188, 20);
         this.textBoxName.TabIndex = 6;
         // 
         // textBoxFirstName
         // 
         this.textBoxFirstName.Location = new System.Drawing.Point(82, 65);
         this.textBoxFirstName.Name = "textBoxFirstName";
         this.textBoxFirstName.ReadOnly = true;
         this.textBoxFirstName.Size = new System.Drawing.Size(188, 20);
         this.textBoxFirstName.TabIndex = 5;
         // 
         // textBoxStartTime
         // 
         this.textBoxStartTime.Location = new System.Drawing.Point(82, 143);
         this.textBoxStartTime.Name = "textBoxStartTime";
         this.textBoxStartTime.ReadOnly = true;
         this.textBoxStartTime.Size = new System.Drawing.Size(188, 20);
         this.textBoxStartTime.TabIndex = 4;
         // 
         // textBoxTarget
         // 
         this.textBoxTarget.Location = new System.Drawing.Point(82, 117);
         this.textBoxTarget.Name = "textBoxTarget";
         this.textBoxTarget.ReadOnly = true;
         this.textBoxTarget.Size = new System.Drawing.Size(188, 20);
         this.textBoxTarget.TabIndex = 3;
         // 
         // textBoxTeam
         // 
         this.textBoxTeam.Location = new System.Drawing.Point(82, 91);
         this.textBoxTeam.Name = "textBoxTeam";
         this.textBoxTeam.ReadOnly = true;
         this.textBoxTeam.Size = new System.Drawing.Size(188, 20);
         this.textBoxTeam.TabIndex = 2;
         // 
         // textBoxStNr
         // 
         this.textBoxStNr.Location = new System.Drawing.Point(82, 13);
         this.textBoxStNr.Name = "textBoxStNr";
         this.textBoxStNr.ReadOnly = true;
         this.textBoxStNr.Size = new System.Drawing.Size(188, 20);
         this.textBoxStNr.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 16);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(28, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "StNr";
         // 
         // panel2
         // 
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel2.Controls.Add(this.buttonExport);
         this.panel2.Controls.Add(this.buttonImport);
         this.panel2.Controls.Add(this.labelScore2);
         this.panel2.Controls.Add(this.labelScore3);
         this.panel2.Controls.Add(this.labelScore4);
         this.panel2.Controls.Add(this.labelScore6);
         this.panel2.Controls.Add(this.labelScore5);
         this.panel2.Controls.Add(this.labelScore1);
         this.panel2.Controls.Add(this.textBoxScore2);
         this.panel2.Controls.Add(this.textBoxScore3);
         this.panel2.Controls.Add(this.buttonSaveScore);
         this.panel2.Controls.Add(this.textBoxScore4);
         this.panel2.Controls.Add(this.textBoxScore5);
         this.panel2.Controls.Add(this.textBoxScore6);
         this.panel2.Controls.Add(this.textBoxScore1);
         this.panel2.Location = new System.Drawing.Point(467, 24);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(191, 279);
         this.panel2.TabIndex = 14;
         // 
         // textBoxScore1
         // 
         this.textBoxScore1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.textBoxScore1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxScore1.Location = new System.Drawing.Point(18, 16);
         this.textBoxScore1.MaxLength = 10;
         this.textBoxScore1.Name = "textBoxScore1";
         this.textBoxScore1.Size = new System.Drawing.Size(100, 22);
         this.textBoxScore1.TabIndex = 0;
         this.textBoxScore1.WordWrap = false;
         this.textBoxScore1.TextChanged += new System.EventHandler(this.textBoxScore1_TextChanged);
         // 
         // textBoxScore6
         // 
         this.textBoxScore6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.textBoxScore6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxScore6.Location = new System.Drawing.Point(18, 146);
         this.textBoxScore6.MaxLength = 10;
         this.textBoxScore6.Name = "textBoxScore6";
         this.textBoxScore6.Size = new System.Drawing.Size(100, 22);
         this.textBoxScore6.TabIndex = 5;
         this.textBoxScore6.WordWrap = false;
         this.textBoxScore6.TextChanged += new System.EventHandler(this.textBoxScore6_TextChanged);
         // 
         // textBoxScore5
         // 
         this.textBoxScore5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.textBoxScore5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxScore5.Location = new System.Drawing.Point(18, 120);
         this.textBoxScore5.MaxLength = 10;
         this.textBoxScore5.Name = "textBoxScore5";
         this.textBoxScore5.Size = new System.Drawing.Size(100, 22);
         this.textBoxScore5.TabIndex = 4;
         this.textBoxScore5.WordWrap = false;
         this.textBoxScore5.TextChanged += new System.EventHandler(this.textBoxScore5_TextChanged);
         // 
         // textBoxScore4
         // 
         this.textBoxScore4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.textBoxScore4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxScore4.Location = new System.Drawing.Point(18, 94);
         this.textBoxScore4.MaxLength = 10;
         this.textBoxScore4.Name = "textBoxScore4";
         this.textBoxScore4.Size = new System.Drawing.Size(100, 22);
         this.textBoxScore4.TabIndex = 3;
         this.textBoxScore4.WordWrap = false;
         this.textBoxScore4.TextChanged += new System.EventHandler(this.textBoxScore4_TextChanged);
         // 
         // textBoxScore3
         // 
         this.textBoxScore3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.textBoxScore3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxScore3.Location = new System.Drawing.Point(18, 68);
         this.textBoxScore3.MaxLength = 10;
         this.textBoxScore3.Name = "textBoxScore3";
         this.textBoxScore3.Size = new System.Drawing.Size(100, 22);
         this.textBoxScore3.TabIndex = 2;
         this.textBoxScore3.WordWrap = false;
         this.textBoxScore3.TextChanged += new System.EventHandler(this.textBoxScore3_TextChanged);
         // 
         // textBoxScore2
         // 
         this.textBoxScore2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.textBoxScore2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxScore2.Location = new System.Drawing.Point(18, 42);
         this.textBoxScore2.MaxLength = 10;
         this.textBoxScore2.Name = "textBoxScore2";
         this.textBoxScore2.Size = new System.Drawing.Size(100, 22);
         this.textBoxScore2.TabIndex = 1;
         this.textBoxScore2.WordWrap = false;
         this.textBoxScore2.TextChanged += new System.EventHandler(this.textBoxScore2_TextChanged);
         // 
         // labelScore1
         // 
         this.labelScore1.AutoSize = true;
         this.labelScore1.Location = new System.Drawing.Point(140, 24);
         this.labelScore1.Name = "labelScore1";
         this.labelScore1.Size = new System.Drawing.Size(13, 13);
         this.labelScore1.TabIndex = 7;
         this.labelScore1.Text = "0";
         // 
         // labelScore5
         // 
         this.labelScore5.AutoSize = true;
         this.labelScore5.Location = new System.Drawing.Point(140, 129);
         this.labelScore5.Name = "labelScore5";
         this.labelScore5.Size = new System.Drawing.Size(13, 13);
         this.labelScore5.TabIndex = 9;
         this.labelScore5.Text = "0";
         // 
         // labelScore6
         // 
         this.labelScore6.AutoSize = true;
         this.labelScore6.Location = new System.Drawing.Point(140, 155);
         this.labelScore6.Name = "labelScore6";
         this.labelScore6.Size = new System.Drawing.Size(13, 13);
         this.labelScore6.TabIndex = 10;
         this.labelScore6.Text = "0";
         // 
         // labelScore4
         // 
         this.labelScore4.AutoSize = true;
         this.labelScore4.Location = new System.Drawing.Point(140, 103);
         this.labelScore4.Name = "labelScore4";
         this.labelScore4.Size = new System.Drawing.Size(13, 13);
         this.labelScore4.TabIndex = 11;
         this.labelScore4.Text = "0";
         // 
         // labelScore3
         // 
         this.labelScore3.AutoSize = true;
         this.labelScore3.Location = new System.Drawing.Point(140, 77);
         this.labelScore3.Name = "labelScore3";
         this.labelScore3.Size = new System.Drawing.Size(13, 13);
         this.labelScore3.TabIndex = 12;
         this.labelScore3.Text = "0";
         // 
         // labelScore2
         // 
         this.labelScore2.AutoSize = true;
         this.labelScore2.Location = new System.Drawing.Point(140, 51);
         this.labelScore2.Name = "labelScore2";
         this.labelScore2.Size = new System.Drawing.Size(13, 13);
         this.labelScore2.TabIndex = 13;
         this.labelScore2.Text = "0";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(155, 309);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBox1.Size = new System.Drawing.Size(503, 207);
         this.textBox1.TabIndex = 15;
         this.textBox1.Text = "Copy data from SIUS TLCD into this text box.";
         // 
         // buttonImport
         // 
         this.buttonImport.Location = new System.Drawing.Point(43, 206);
         this.buttonImport.Name = "buttonImport";
         this.buttonImport.Size = new System.Drawing.Size(75, 23);
         this.buttonImport.TabIndex = 14;
         this.buttonImport.Text = "&Import";
         this.buttonImport.UseVisualStyleBackColor = true;
         this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
         // 
         // buttonExport
         // 
         this.buttonExport.Location = new System.Drawing.Point(43, 235);
         this.buttonExport.Name = "buttonExport";
         this.buttonExport.Size = new System.Drawing.Size(75, 23);
         this.buttonExport.TabIndex = 15;
         this.buttonExport.Text = "&Export";
         this.buttonExport.UseVisualStyleBackColor = true;
         this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(681, 538);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.listBoxShooters);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.Name = "MainForm";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
         this.Text = "SIUS Data Helper";
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private ListBox listBoxShooters;
      private StatusStrip statusStrip1;
      private ToolStripStatusLabel toolStripStatusLabel1;
      private MenuStrip menuStrip1;
      private ToolStripMenuItem fileToolStripMenuItem;
      private ToolStripMenuItem exitToolStripMenuItem;
      private ToolStripMenuItem helpToolStripMenuItem;
      private ToolStripMenuItem aboutToolStripMenuItem;
      private ToolStripMenuItem generateToolStripMenuItem;
      private Button buttonSaveScore;
      private Panel panel1;
      private Label label1;
      private Label label6;
      private Label label5;
      private Label label4;
      private Label label3;
      private Label label2;
      private TextBox textBoxName;
      private TextBox textBoxFirstName;
      private TextBox textBoxStartTime;
      private TextBox textBoxTarget;
      private TextBox textBoxTeam;
      private TextBox textBoxStNr;
      private Label label8;
      private TextBox textBoxNat;
      private Label label7;
      private TextBox textBoxRelay;
      private Panel panel2;
      private TextBox textBoxScore2;
      private TextBox textBoxScore3;
      private TextBox textBoxScore4;
      private TextBox textBoxScore5;
      private TextBox textBoxScore6;
      private TextBox textBoxScore1;
      private Label labelScore2;
      private Label labelScore3;
      private Label labelScore4;
      private Label labelScore6;
      private Label labelScore5;
      private Label labelScore1;
      private TextBox textBox1;
      private Button buttonImport;
      private Button buttonExport;
   }
}