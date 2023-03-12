namespace Stars
{
    public partial class Frm : Form
    {
        int n = 50;
        SolidBrush x = new SolidBrush(Color.Black);
        Pen pn = new Pen(Color.White, 1);
        SolidBrush[] col = { new SolidBrush(Color.White), new SolidBrush(Color.WhiteSmoke),
                new SolidBrush(Color.FloralWhite), new SolidBrush(Color.AliceBlue), new SolidBrush(Color.LightYellow) };
        Image[] col2 = { Image.FromFile(Path.GetFullPath("earth.jpg")), Image.FromFile(Path.GetFullPath("mars.jpg")), Image.FromFile(Path.GetFullPath("neptune.jpg")) };

        Random random = new Random();
        Point p = new Point();
        bool ImageTexture = false;
        public Frm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            progressBar1.Maximum = n;
            for (int i = n; i > 0; i--)
            {
                p.X = random.Next(0, this.Width);
                p.Y = random.Next(0, this.Height);
                int offset = random.Next(1, 50);
                Rectangle rect = new Rectangle(p.X, p.Y, offset, offset);
                if (ImageTexture)
                {
                    TextureBrush myTextureBrush = new TextureBrush(col2[random.Next(0, col2.Length)]);
                    g.FillEllipse(myTextureBrush, rect);
                }
                else
                {
                    g.FillEllipse(col[random.Next(col.Length)], rect);
                }
                progressBar1.Value = n - i;

            }
            progressBar1.Value = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ImageTexture = true;
            }
            else
            {
                ImageTexture = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            g.Clear(Color.Black);
            g.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt16(textBox1.Text);
            }
            catch 
            {
                textBox1.Text = string.Empty;
            }
        }
    }
}