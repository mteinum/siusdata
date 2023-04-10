using System;
using System.Collections.Generic;
using System.Linq;

namespace SiusData
{
   class CsvParser
   {
      public static IEnumerable<T> Parse<T>(IEnumerable<string> lines) where T : new()
      {
         var properties = typeof(T).GetProperties();

         return lines.Select(line =>
         {
            var parts = line.Split(';');

            if (parts.Length != properties.Length)
               throw new ArgumentException($"{typeof(T)} has {properties.Length} properties. input has {parts.Length} parts. line='{line}'");

            var result = new T();

            for (int i = 0; i < properties.Length; i++)
            {
               properties[i].SetValue(result, parts[i]);
            }

            return result;
         });
      }
   }
}