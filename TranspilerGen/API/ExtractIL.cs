using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Mono.Reflection;
using TranspilerGen.Info;

namespace TranspilerGen.API
{
    public static class ExtractIL
    {
        public static Dictionary<int, Instruction> getDifference(MethodInfo method1, MethodInfo method2)
        {
            var il1 = method1.GetInstructions(); // modified method
            var il2 = method2.GetInstructions(); // original method
            Dictionary<int, Instruction> difference = new Dictionary<int, Instruction>();

            return difference;
        }
    }
}