using System;
using System.Windows.Forms;
using TranspilerGen.Info;

namespace TranspilerGen.Handlers
{
    public class ButtonHandler
    {
        public void StartbuttonClick(object sender, EventArgs e, Button button)
        {
            if (GenInfo.IsValid())
            {
                API.ExtractIL.getDifference(
                    GenInfo.OriginalFile.GetType(GenInfo.Class.FullName).GetMethod(GenInfo.Method.Name),
                    GenInfo.Method);
            }
        }
    }
}