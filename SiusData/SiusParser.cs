using System.IO;
using System.Linq;

namespace SiusData
{
   public class SiusParser
   {
      public static StartListFile ParseStartList(string fileName)
      {
         return new StartListFile
         {
            FileName = fileName,
            Shooters = CsvParser.Parse<Shooter>(
               File.ReadLines(fileName, System.Text.Encoding.GetEncoding(1252))).ToArray()
         };
      }

      public static ShotDataFile ParseShotData(string fileName)
      {
         return new ShotDataFile
         {
            FileName = fileName,
            Shots = CsvParser.Parse<ShotData>(File.ReadLines(fileName)).ToList()
         };
      }
   }
}