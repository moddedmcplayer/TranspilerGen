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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Startbutton
            // 
            this.Startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Startbutton.Location = new System.Drawing.Point(318, 363);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(148, 49);
            this.Startbutton.TabIndex = 0;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(166, 307);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 40);
            this.progressBar1.TabIndex = 2;
            // 
            // FilePathTextbox2
            // 
            this.FilePathTextbox2.Location = new System.Drawing.Point(145, 175);
            this.FilePathTextbox2.Name = "FilePathTextbox2";
            this.FilePathTextbox2.Size = new System.Drawing.Size(358, 20);
            this.FilePathTextbox2.TabIndex = 3;
            this.FilePathTextbox2.Text = "Enter path";
            // 
            // FilePathTextbox1
            // 
            this.FilePathTextbox1.Location = new System.Drawing.Point(145, 122);
            this.FilePathTextbox1.Name = "FilePathTextbox1";
            this.FilePathTextbox1.Size = new System.Drawing.Size(358, 20);
            this.FilePathTextbox1.TabIndex = 4;
            this.FilePathTextbox1.Text = "Enter path";
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
            this.OriginalFileSelectorLabel.Location = new System.Drawing.Point(160, 110);
            this.OriginalFileSelectorLabel.Name = "OriginalFileSelectorLabel";
            this.OriginalFileSelectorLabel.Size = new System.Drawing.Size(61, 12);
            this.OriginalFileSelectorLabel.TabIndex = 6;
            this.OriginalFileSelectorLabel.Text = "Original file path";
            // 
            // ModifiedSlectorLabel
            // 
            this.ModifiedSlectorLabel.Location = new System.Drawing.Point(160, 158);
            this.ModifiedSlectorLabel.Name = "ModifiedSlectorLabel";
            this.ModifiedSlectorLabel.Size = new System.Drawing.Size(72, 14);
            this.ModifiedSlectorLabel.TabIndex = 7;
            this.ModifiedSlectorLabel.Text = "Modified File";
            // 
            // BrowseButton2
            // 
            this.BrowseButton2.Location = new System.Drawing.Point(499, 175);
            this.BrowseButton2.Name = "BrowseButton2";
            this.BrowseButton2.Size = new System.Drawing.Size(61, 20);
            this.BrowseButton2.TabIndex = 8;
            this.BrowseButton2.Text = "Browse";
            this.BrowseButton2.UseVisualStyleBackColor = true;
            // 
            // BrowseButton1
            // 
            this.BrowseButton1.Location = new System.Drawing.Point(499, 122);
            this.BrowseButton1.Name = "BrowseButton1";
            this.BrowseButton1.Size = new System.Drawing.Size(61, 19);
            this.BrowseButton1.TabIndex = 9;
            this.BrowseButton1.Text = "Browse";
            this.BrowseButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox1;

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