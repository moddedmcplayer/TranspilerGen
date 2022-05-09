using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Mono.Reflection;
using TranspilerGen.Info;

namespace TranspilerGen.ILInterface;

public class IILExtractor
{
     public static Dictionary<int, string> GetNew(List<Instruction> instructions1, List<string> instructions2)
     {
         var result = new Dictionary<int, string>();
         List<string> primary = instructions1.ConvertAll(x => x.ToString().Remove(0, 10));
         List<string> secondary = instructions2.ConvertAll(x => x.Remove(0, 10));

         int offset = 0;
         for(int i = 0; i < primary.Count; i++)
         {
             if (primary[i] != secondary[i-offset] || (i - offset) == secondary.Count)
             {
                 result.Add(i, primary[i]);
                 offset++;
             }
         }

         return result;
     }
}