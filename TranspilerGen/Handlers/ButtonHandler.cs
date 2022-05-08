using System;
using System.Linq;
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
                var newIL = IILExtractor.GetNew(
                    GenInfo.Method.GetInstructions().ToList(),
                    GenInfo.proxy.GetInstructions(GenInfo.Class.FullName, GenInfo.Method.Name).ToList()
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