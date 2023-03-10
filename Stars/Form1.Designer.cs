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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(663, 406);
            button1.Name = "button1";
            button1.Size = new Size(125, 32);
            button1.TabIndex = 0;
            button1.Text = "Generate stars";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Cursor = Cursors.Arrow;
            Name = "Frm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}