namespace Stars
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }
        private void form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            Pen pn = new Pen(Color.White, 1);
            SolidBrush[] col = { new SolidBrush(Color.White), new SolidBrush(Color.WhiteSmoke),
                new SolidBrush(Color.FloralWhite), new SolidBrush(Color.AliceBlue), new SolidBrush(Color.LightYellow) };
            Random random = new Random();
            Point p = new Point();
            for (int i = 0; i < 500; i++)
            {
                p.X = random.Next(0, 900);
                p.Y = random.Next(0, 900);
                int offset = random.Next(1, 7);
                Rectangle rect = new Rectangle(p.X, p.Y, offset, offset);
                g.FillEllipse(col[random.Next(col.Length)], rect);
            }
        }
    }
}