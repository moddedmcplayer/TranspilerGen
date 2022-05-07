using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TranspilerGen.Info;

namespace TranspilerGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            //ignore
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
                FilePathTextbox2.Text = openFileDialog2.FileName;
            }
        }

        private void LetterSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowClasses();
        }

        private void MethodSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenInfo.Method = (MethodInfo)this.MethodSelector.SelectedItem;
        }

        private void ClassSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMethods();
        }
    }
}