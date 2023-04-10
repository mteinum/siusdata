using System.IO;
using System.Text;

namespace SiusData
{
   public class ShotDataFileWriter
   {
      public void Write(ShotDataFile file)
      {
         using (var stream = File.OpenWrite(file.FileName))
         {
            using (var writer = new StreamWriter(stream))
            {
               foreach (var shotData in file.Shots)
               {
                  writer.WriteLine(Serialize(shotData));
               }
            }
         }
      }

      private string Serialize(ShotData shotData)
      {
         var properties = typeof(ShotData).GetProperties();
         var sb = new StringBuilder();

         for (int i = 0; i < properties.Length; i++)
         {
            if (i > 0) sb.Append(';');

            sb.Append(properties[i].GetValue(shotData));
         }

         return sb.ToString();

      }
   }
}