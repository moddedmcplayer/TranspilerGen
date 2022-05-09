using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mono.Reflection;
using TranspilerGen.ILInterface;
using TranspilerGen.Info;

namespace TranspilerGen.Handlers
{
    public class ButtonHandler
    {
        public void StartbuttonClick(object sender, EventArgs e, Button button)
        {
            if (GenInfo.IsValid())
            {
                GenInfo.ProxyGetInstructions(GenInfo.GetInfoArray);
                string[] inst = File.ReadAllLines("ILCode(dont edit).txt");
                
                var newIL = IILExtractor.GetNew(
                    GenInfo.Method.GetInstructions().ToList(),
                    inst.ToList()
                );
                foreach (var il in newIL)
                {
                    Program.PrintConsole($"{il.Key}");
                    Program.PrintConsole(il.Value.ToString());
                }
            }
        }
    }
}