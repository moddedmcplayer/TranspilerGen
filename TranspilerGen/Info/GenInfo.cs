using System;
using System.Reflection;

namespace TranspilerGen.Info
{
    public static class GenInfo
    {
        public static Assembly OriginalFile { get; set; }
        public static Assembly ModdedFile { get; set; }
        public static Type Class { get; set; }
        public static MethodInfo Method { get; set; }

        public static bool IsValid() => !(OriginalFile is null || ModdedFile is null || Class is null || Method is null);
        public static bool SelectedFiles() => !(OriginalFile is null || ModdedFile is null);
    }
}