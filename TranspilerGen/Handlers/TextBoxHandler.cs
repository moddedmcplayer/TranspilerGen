using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TranspilerGen.Info;

namespace TranspilerGen.Handlers
{
    public class TextBoxHandler
    {
        public void FilePath2TextChanged(object sender, EventArgs eventArgs, TextBox box, out string returnMessage, out bool success)
        {
            try
            {
                GenInfo.ModdedFile = Assembly.LoadFrom(box.Text);
                success = true;
                returnMessage = "Found and loaded assembly!";
            }
            catch (ArgumentException e)
            {
                success = false;
                returnMessage = "Not a valid path!";
            }
            catch (FileLoadException e)
            {
                success = false;
                returnMessage = "Unable to load assembly!!";
            }
            catch (FileNotFoundException e)
            {
                success = false;
                returnMessage = "Unable to find assembly!";
            }
            catch (Exception e)
            {
                success = false;
                returnMessage = "An error occured!";
            }
        }

        public void FilePath1TextChanged(object sender, EventArgs eventArgs, TextBox box, out string returnMessage, out bool success)
        {
            try
            {
                GenInfo.OriginalFile = Assembly.LoadFrom(box.Text);
                success = true;
                returnMessage = "Found and loaded assembly!";
            }
            catch (ArgumentException e)
            {
                success = false;
                returnMessage = "Not a valid path!";
            }
            catch (FileLoadException e)
            {
                success = false;
                returnMessage = "Unable to load assembly!!";
            }
            catch (FileNotFoundException e)
            {
                success = false;
                returnMessage = "Unable to find assembly!";
            }
            catch (Exception e)
            {
                success = false;
                returnMessage = "An error occured!";
            }
        }
    }
}