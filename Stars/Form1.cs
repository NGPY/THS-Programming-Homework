using System.Reflection;
using Vlc.DotNet.Forms;

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
            if (n > 500)
            {
                label2.Visible = true;
            }
            for (int i = n; i > 0; i--)
            {
                p.X = random.Next(0, this.Width);
                p.Y = random.Next(0, this.Height);
                int offset = random.Next(1, 7);
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
            label2.Visible = false;
            


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

        private void vlcControl2_DoubleClick(object sender, EventArgs e)
        {
            var control = vlcControl2;
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            var libDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
            control.BeginInit();
            control.BackColor = Color.White;
            control.VlcLibDirectory = libDirectory;
            control.SetBounds(20, 20, 500, 500);
            control.Show();
            control.EndInit();
            control.ResetMedia();

            string final = "C:\\Users\\bened\\Documents\\Programming-Homework\\Stars\\bin\\Debug\\net6.0-windows\\videoplayback.mp4";
            control.Play(new Uri(final).AbsoluteUri);
            
        }
    }
}