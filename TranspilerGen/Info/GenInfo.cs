using System;
using System.Reflection;

namespace TranspilerGen.Info
{
    [Serializable]
    public static class GenInfo
    {
        public static AppDomain OriginalFile;
        public static ProxyDomain proxy;
        
        public static Assembly ModdedAssembly;
        
        public static TypeInfo Class { get; set; }
        public static MethodInfo Method { get; set; }

        public static bool IsValid() => !(proxy.IsNull() || ModdedAssembly is null || Class is null || Method is null);
        public static bool SelectedFiles() => !(proxy.IsNull() || ModdedAssembly is null);
    }
}