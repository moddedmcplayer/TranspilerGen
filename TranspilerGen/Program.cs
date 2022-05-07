using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranspilerGen.Handlers;

namespace TranspilerGen
{
    static class Program
    {
        /// <summary>
        /// The EventHandler for anything clicking related
        /// </summary>
        public static ButtonHandler ButtonHandler;
        /// <summary>
        /// The EventHandler for anything selecting related
        /// </summary>
        public static SelectorHandler SelectorHandler;
        /// <summary>
        /// The EventHandler for anything text related
        /// </summary>
        public static TextBoxHandler TextBoxHandler;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ButtonHandler = new ButtonHandler();
            SelectorHandler = new SelectorHandler();
            TextBoxHandler = new TextBoxHandler();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}