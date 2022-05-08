using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Mono.Reflection;
using TranspilerGen.Info;

namespace TranspilerGen.ILInterface;

public class IILExtractor
{
     public static Dictionary<int, Tuple<bool, string>> GetNew(List<Instruction> instructions1, List<Instruction> instructions2)
     {
         var result = new Dictionary<int, Tuple<bool, string>>();
         List<string> primary = instructions1.ConvertAll(x => x.ToString().Remove(0, 10));
         List<string> secondary = instructions1.ConvertAll(x => x.ToString().Remove(0, 10));
         List<string> primary_arr;
         List<string> secondary_arr;
         if (primary.Count >= secondary.Count)
         {
             primary_arr = primary;
             secondary_arr = secondary;
         }
         else
         {
             primary_arr = secondary;
             secondary_arr = primary;
         }

         int primary_index = 0;
         int original_sub = 0;
         int sub_pos = 0;
         for (; primary_index < primary_arr.Count && sub_pos < secondary_arr.Count; primary_index++, sub_pos++)
         {
             //Console.WriteLine("primary " + primary_arr[primary_index] + " and " + secondary_arr[sub_pos]);
             if (primary_arr[primary_index] != secondary_arr[sub_pos])
             {
                 original_sub = sub_pos;
                 Dictionary<int, Tuple<bool, string>> temp = new Dictionary<int, Tuple<bool, string>>();
                 while (sub_pos < secondary_arr.Count)
                 {
                     if (primary_arr[primary_index] != secondary_arr[sub_pos])
                     {
                         temp.Add(sub_pos,
                             new Tuple<bool, string>(primary.Count >= secondary.Count, secondary_arr[sub_pos]));
                     }
                     else
                     {
                         break;
                     }

                     sub_pos++;
                 }

                 if (sub_pos >= secondary_arr.Count)
                 {
                     sub_pos = original_sub - 1;
                     result.Add(primary_index,
                         new Tuple<bool, string>(primary.Count >= secondary.Count, primary_arr[primary_index]));
                 }
                 else
                 {
                     foreach (var kvp in temp)
                     {
                         result.Add(kvp.Key, kvp.Value);
                     }
                 }
             }
         }

         for (; primary_index < primary_arr.Count; primary_index++)
         {
             result.Add(primary_index,
                 new Tuple<bool, string>(primary.Count >= secondary.Count, primary_arr[primary_index]));
         }

         for (; sub_pos < secondary_arr.Count; sub_pos++)
         {
             result.Add(sub_pos, new Tuple<bool, string>(primary.Count >= secondary.Count, secondary_arr[sub_pos]));
         }

         return result;
     }
}