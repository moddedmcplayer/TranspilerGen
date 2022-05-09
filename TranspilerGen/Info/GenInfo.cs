using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using Mono.Reflection;

namespace TranspilerGen.Info
{
    public static class GenInfo
    {
        public static AppDomain OriginalFile;
        public static ProxyDomain proxy;
        public static Assembly ModdedAssembly;
        
        public static TypeInfo Class { get; set; }
        public static MethodInfo Method { get; set; }
        
        public static void PieceOfCode(MethodInfo input)
        {
            var instructions = input.GetInstructions();
            StreamWriter sw = new StreamWriter("ILCode(dont edit).txt", false);
            foreach (var inst in instructions)
            {
                sw.WriteLine(inst.ToString());
            }
            sw.Close();
        }
        
        public static bool IsValid() => !(proxy.IsNull() || ModdedAssembly is null || Class is null || Method is null);
        public static bool SelectedFiles() => !(proxy.IsNull() || ModdedAssembly is null);
        public static void ProxyGetInstructions(string[] input)
        {
            if (input.Length < 2)
                throw new ArgumentException();
            proxy.Execute(PieceOfCode, input);
        }

        public static string[] GetInfoArray => new string[]
        {
            GenInfo.Class.FullName,
            GenInfo.Method.Name
        };
    }
}