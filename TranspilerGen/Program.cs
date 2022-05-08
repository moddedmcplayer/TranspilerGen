using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranspilerGen.Handlers;
using TranspilerGen.Info;

namespace TranspilerGen
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        
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

        private static bool hasConsole = false;
        public static void PrintConsole(string txt)
        {
            if (!hasConsole)
            {
                AllocConsole();
            }
            Console.WriteLine(txt);
        }

        public static string GetFileName(this string input)
        {
            List<char> list = input.Reverse().ToList();
            int i = 0;
            foreach (var item in list)
            {
                if (item == "\\"[0])
                {
                    return string.Join("", string.Join("", list).Substring(0, i).Reverse());
                }

                i++;
            }

            return input;
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GenInfo.OriginalFile = AppDomain.CreateDomain("Original");
            GenInfo.proxy = (ProxyDomain)GenInfo.OriginalFile.CreateInstanceAndUnwrap(Assembly.GetExecutingAssembly().FullName, typeof(ProxyDomain).FullName);
            
            ButtonHandler = new ButtonHandler();
            SelectorHandler = new SelectorHandler();
            TextBoxHandler = new TextBoxHandler();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}