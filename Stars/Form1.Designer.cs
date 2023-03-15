using System.Reflection;
using Vlc.DotNet.Forms;

namespace Stars
{
    partial class Frm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            checkBox1 = new CheckBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            vlcControl2 = new VlcControl();
            ((System.ComponentModel.ISupportInitialize)vlcControl2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 0;
            button1.Text = "Generate stars";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(12, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(99, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Image texture";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(12, 67);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(11, 125);
            progressBar1.MarqueeAnimationSpeed = 1;
            progressBar1.Maximum = 500;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(169, 23);
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(117, 43);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 4;
            label1.Text = "(High RAM usage)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 96);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "N of stars";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(118, 20);
            label2.Name = "label2";
            label2.Size = new Size(358, 15);
            label2.TabIndex = 6;
            label2.Text = "High number of stars drawn detected, Memory usage may be high";
            label2.Visible = false;
            // 
            // vlcControl2
            // 
            vlcControl2.BackColor = Color.Black;
            vlcControl2.Location = new Point(396, 357);
            vlcControl2.Name = "vlcControl2";
            vlcControl2.Size = new Size(487, 505);
            vlcControl2.Spu = -1;
            vlcControl2.TabIndex = 7;
            vlcControl2.Text = "vlcControl2";
            vlcControl2.VlcMediaplayerOptions = null;
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            vlcControl2.VlcLibDirectory = new DirectoryInfo(currentDirectory + "\\Vlc.DotNet.Forms.dll");
            vlcControl2.DoubleClick += vlcControl2_DoubleClick;
            // 
            // Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(884, 861);
            Controls.Add(vlcControl2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Star generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
        private ProgressBar progressBar1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private VlcControl vlcControl2;
    }
}