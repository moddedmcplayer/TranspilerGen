using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Mono.Reflection;
using TranspilerGen.Info;

namespace TranspilerGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Closed(object sender, EventArgs e)
        {
            if (File.Exists("ILCode(dont edit).txt"))
                File.Delete("ILCode(dont edit).txt");
        }
        
        private void Startbutton_Click(object sender, EventArgs e)
        {
            Program.ButtonHandler.StartbuttonClick(sender, e, Startbutton);
        }

        private void FilePathTextbox2_TextChanged(object sender, EventArgs e)
        {
            Program.TextBoxHandler.FilePath2TextChanged(sender, e, FilePathTextbox2, out var returnMessage, out var success);
            if (success)
            {
                EnterPath2Caption.BackColor = Color.Green;
                EnterPath2Caption.Text = returnMessage;
            }
            else
            {
                EnterPath2Caption.BackColor = Color.Red;
                EnterPath2Caption.Text = returnMessage;
            }
            if(GenInfo.SelectedFiles())
                ShowCharacters();
            else
            {
                HideAll();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosed += Form_Closed;
        }

        private void FilePathTextbox1_TextChanged(object sender, EventArgs e)
        {
            Program.TextBoxHandler.FilePath1TextChanged(sender, e, FilePathTextbox1, out var returnMessage, out var success);
            if (success)
            {
                EnterPath1Caption.BackColor = Color.Green;
                EnterPath1Caption.Text = returnMessage;
            }
            else
            {
                EnterPath1Caption.BackColor = Color.Red;
                EnterPath1Caption.Text = returnMessage;
            }
            if(GenInfo.SelectedFiles())
                ShowCharacters();
        }

        private void BrowseButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "DLLs (*.dll)|*.dll";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if(openFileDialog1.FileName == FilePathTextbox2.Text)
                {
                    throw new ArgumentException();
                }
                FilePathTextbox1.Text = openFileDialog1.FileName;
            }
        }

        private void BrowseButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "DLLs (*.dll)|*.dll";
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                if(openFileDialog2.FileName == FilePathTextbox1.Text)
                {
                    throw new ArgumentException();
                }
                FilePathTextbox2.Text = openFileDialog2.FileName;
            }
        }

        private void LetterSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowClasses();
        }

        private void MethodSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenInfo.Method = Program.SelectorHandler.methods[this.MethodSelector.SelectedIndex];
            this.reload.Visible = true;
        }

        private void ClassSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMethods();
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("Config.txt", false);
            
            if(GenInfo.IsValid())
            {
                tw.WriteLine(this.FilePathTextbox1.Text);
                tw.WriteLine(this.FilePathTextbox2.Text);
                tw.WriteLine(this.LetterSelector.SelectedItem);
                tw.WriteLine(GenInfo.Class.FullName);
                tw.WriteLine(GenInfo.Method.Name);
            }
            
            tw.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            TextReader tr = new StreamReader("Config.txt");
            
            string FilePath1 = tr.ReadLine();
            string FilePath2 = tr.ReadLine();
            string Letter = tr.ReadLine();
            string ClassStr = tr.ReadLine();
            string Method = tr.ReadLine();

            this.FilePathTextbox1.Text = FilePath1;
            this.FilePathTextbox2.Text = FilePath2;
            this.LetterSelector.SelectedItem = Letter;
            this.ClassSelector.SelectedIndex = Program.SelectorHandler.types.IndexOf(GenInfo.ModdedAssembly.GetType(ClassStr).GetTypeInfo());
            this.MethodSelector.SelectedIndex = Program.SelectorHandler.methods.IndexOf(GenInfo.ModdedAssembly.GetType(ClassStr).GetMethod(Method));

            tr.Close();
        }

        // show IL button
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var inst in GenInfo.Method.GetInstructions())
            {
                Program.PrintConsole(inst.ToString());
            }
        }
    }
}