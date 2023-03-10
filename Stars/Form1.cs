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
            Random random = new Random();
            for (int i = 10; i > 0; i--)
            {
                Point p = new Point();
                p.X = random.Next(0, 500);
                p.Y = random.Next(0, 500);
                Point newP = Point.Empty;

                newP.X = p.X + 1;
                newP.Y = p.Y + 1;


                g.DrawLine(pn, p, newP);
            }

        }
    }
}