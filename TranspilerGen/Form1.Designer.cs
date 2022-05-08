using System;
using System.Linq;
using System.Reflection;
using TranspilerGen.Info;

namespace TranspilerGen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        public void HideAll()
        {
            this.LetterSelector.Visible = false;
            this.ClassSelector.Visible = false;
            this.MethodSelector.Visible = false;
            this.reload.Visible = false;
        }
        
        public void ShowCharacters()
        {
            this.LetterSelector.Items.Clear();
            this.LetterSelector.Visible = true;
            this.LetterSelector.Items.AddRange(Program.SelectorHandler.getLetters().ToArray());
        }

        public void ShowClasses()
        {
            if (!this.LetterSelector.Visible)
                return;
            this.ClassSelector.Items.Clear();
            this.ClassSelector.Visible = true;
            this.ClassSelector.Items.AddRange(Program.SelectorHandler.getClasses(this.LetterSelector.SelectedItem.ToString()[0]));
        }

        public void ShowMethods()
        {
            if (!this.ClassSelector.Visible)
                return;
            this.MethodSelector.Items.Clear();
            this.MethodSelector.Items.AddRange(Program.SelectorHandler.getMethods(GenInfo.ModdedAssembly.GetType((string)this.ClassSelector.SelectedItem).GetTypeInfo()));
            this.MethodSelector.Visible = true;
            GenInfo.Class = Program.SelectorHandler.types[this.ClassSelector.SelectedIndex];
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Startbutton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.FilePathTextbox2 = new System.Windows.Forms.TextBox();
            this.FilePathTextbox1 = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.OriginalFileSelectorLabel = new System.Windows.Forms.Label();
            this.ModifiedSlectorLabel = new System.Windows.Forms.Label();
            this.BrowseButton2 = new System.Windows.Forms.Button();
            this.BrowseButton1 = new System.Windows.Forms.Button();
            this.EnterPath2Caption = new System.Windows.Forms.Label();
            this.EnterPath1Caption = new System.Windows.Forms.Label();
            this.ClassSelector = new System.Windows.Forms.ComboBox();
            this.LetterSelector = new System.Windows.Forms.ComboBox();
            this.MethodSelector = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Startbutton
            // 
            this.Startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Startbutton.Location = new System.Drawing.Point(318, 389);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(148, 49);
            this.Startbutton.TabIndex = 0;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(160, 343);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 40);
            this.progressBar1.TabIndex = 2;
            // 
            // FilePathTextbox2
            // 
            this.FilePathTextbox2.Location = new System.Drawing.Point(145, 192);
            this.FilePathTextbox2.Name = "FilePathTextbox2";
            this.FilePathTextbox2.Size = new System.Drawing.Size(358, 20);
            this.FilePathTextbox2.TabIndex = 3;
            this.FilePathTextbox2.Text = "Enter path";
            this.FilePathTextbox2.TextChanged += new System.EventHandler(this.FilePathTextbox2_TextChanged);
            // 
            // FilePathTextbox1
            // 
            this.FilePathTextbox1.Location = new System.Drawing.Point(145, 122);
            this.FilePathTextbox1.Name = "FilePathTextbox1";
            this.FilePathTextbox1.Size = new System.Drawing.Size(358, 20);
            this.FilePathTextbox1.TabIndex = 4;
            this.FilePathTextbox1.Text = "Enter path";
            this.FilePathTextbox1.TextChanged += new System.EventHandler(this.FilePathTextbox1_TextChanged);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Title.Location = new System.Drawing.Point(237, 39);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(347, 43);
            this.Title.TabIndex = 5;
            this.Title.Text = "Transpiler generator";
            // 
            // OriginalFileSelectorLabel
            // 
            this.OriginalFileSelectorLabel.Location = new System.Drawing.Point(160, 107);
            this.OriginalFileSelectorLabel.Name = "OriginalFileSelectorLabel";
            this.OriginalFileSelectorLabel.Size = new System.Drawing.Size(61, 12);
            this.OriginalFileSelectorLabel.TabIndex = 6;
            this.OriginalFileSelectorLabel.Text = "Original file path";
            // 
            // ModifiedSlectorLabel
            // 
            this.ModifiedSlectorLabel.Location = new System.Drawing.Point(160, 175);
            this.ModifiedSlectorLabel.Name = "ModifiedSlectorLabel";
            this.ModifiedSlectorLabel.Size = new System.Drawing.Size(72, 14);
            this.ModifiedSlectorLabel.TabIndex = 7;
            this.ModifiedSlectorLabel.Text = "Modified File";
            // 
            // BrowseButton2
            // 
            this.BrowseButton2.Location = new System.Drawing.Point(499, 192);
            this.BrowseButton2.Name = "BrowseButton2";
            this.BrowseButton2.Size = new System.Drawing.Size(61, 20);
            this.BrowseButton2.TabIndex = 8;
            this.BrowseButton2.Text = "Browse";
            this.BrowseButton2.UseVisualStyleBackColor = true;
            this.BrowseButton2.Click += new System.EventHandler(this.BrowseButton2_Click);
            // 
            // BrowseButton1
            // 
            this.BrowseButton1.Location = new System.Drawing.Point(499, 122);
            this.BrowseButton1.Name = "BrowseButton1";
            this.BrowseButton1.Size = new System.Drawing.Size(61, 19);
            this.BrowseButton1.TabIndex = 9;
            this.BrowseButton1.Text = "Browse";
            this.BrowseButton1.UseVisualStyleBackColor = true;
            this.BrowseButton1.Click += new System.EventHandler(this.BrowseButton1_Click);
            // 
            // EnterPath2Caption
            // 
            this.EnterPath2Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.EnterPath2Caption.Location = new System.Drawing.Point(145, 215);
            this.EnterPath2Caption.Name = "EnterPath2Caption";
            this.EnterPath2Caption.Size = new System.Drawing.Size(294, 17);
            this.EnterPath2Caption.TabIndex = 11;
            this.EnterPath2Caption.Text = "Waiting for input";
            // 
            // EnterPath1Caption
            // 
            this.EnterPath1Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.EnterPath1Caption.Location = new System.Drawing.Point(145, 144);
            this.EnterPath1Caption.Name = "EnterPath1Caption";
            this.EnterPath1Caption.Size = new System.Drawing.Size(294, 14);
            this.EnterPath1Caption.TabIndex = 12;
            this.EnterPath1Caption.Text = "Waiting for input";
            // 
            // ClassSelector
            // 
            this.ClassSelector.AllowDrop = true;
            this.ClassSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ClassSelector.FormattingEnabled = true;
            this.ClassSelector.Location = new System.Drawing.Point(206, 271);
            this.ClassSelector.Name = "ClassSelector";
            this.ClassSelector.Size = new System.Drawing.Size(399, 24);
            this.ClassSelector.TabIndex = 13;
            this.ClassSelector.Visible = false;
            this.ClassSelector.SelectedIndexChanged += new System.EventHandler(this.ClassSelector_SelectedIndexChanged);
            // 
            // LetterSelector
            // 
            this.LetterSelector.AllowDrop = true;
            this.LetterSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LetterSelector.FormattingEnabled = true;
            this.LetterSelector.Location = new System.Drawing.Point(160, 271);
            this.LetterSelector.Name = "LetterSelector";
            this.LetterSelector.Size = new System.Drawing.Size(40, 24);
            this.LetterSelector.Sorted = true;
            this.LetterSelector.TabIndex = 14;
            this.LetterSelector.Visible = false;
            this.LetterSelector.SelectedIndexChanged += new System.EventHandler(this.LetterSelector_SelectedIndexChanged);
            // 
            // MethodSelector
            // 
            this.MethodSelector.AllowDrop = true;
            this.MethodSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MethodSelector.FormattingEnabled = true;
            this.MethodSelector.Location = new System.Drawing.Point(206, 301);
            this.MethodSelector.Name = "MethodSelector";
            this.MethodSelector.Size = new System.Drawing.Size(399, 24);
            this.MethodSelector.TabIndex = 15;
            this.MethodSelector.Visible = false;
            this.MethodSelector.SelectedIndexChanged += new System.EventHandler(this.MethodSelector_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(664, 127);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(62, 30);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(664, 185);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(62, 27);
            this.LoadButton.TabIndex = 17;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(665, 235);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(60, 36);
            this.reload.TabIndex = 18;
            this.reload.Text = "Show IL\r\n";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Visible = false;
            this.reload.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MethodSelector);
            this.Controls.Add(this.LetterSelector);
            this.Controls.Add(this.ClassSelector);
            this.Controls.Add(this.EnterPath1Caption);
            this.Controls.Add(this.EnterPath2Caption);
            this.Controls.Add(this.BrowseButton1);
            this.Controls.Add(this.BrowseButton2);
            this.Controls.Add(this.ModifiedSlectorLabel);
            this.Controls.Add(this.OriginalFileSelectorLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.FilePathTextbox1);
            this.Controls.Add(this.FilePathTextbox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Startbutton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button reload;

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;

        private System.Windows.Forms.ComboBox ClassSelector;
        private System.Windows.Forms.ComboBox LetterSelector;
        private System.Windows.Forms.ComboBox MethodSelector;

        private System.Windows.Forms.Label EnterPath2Caption;
        private System.Windows.Forms.Label EnterPath1Caption;

        private System.Windows.Forms.Label OriginalFileSelectorLabel;
        private System.Windows.Forms.Label ModifiedSlectorLabel;
        private System.Windows.Forms.Button BrowseButton2;
        private System.Windows.Forms.Button BrowseButton1;

        private System.Windows.Forms.TextBox FilePathTextbox1;
        private System.Windows.Forms.Label Title;

        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox FilePathTextbox2;

        #endregion
    }
}