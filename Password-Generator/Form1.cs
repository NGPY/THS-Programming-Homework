namespace Password_Generator
{
    public partial class Form1 : Form
    {
        string[] availableChars = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
            "!", "£", "$", "%", "^", "&", "*", "(", ")", "_", "#", "'", "/", ".", ","};
        string previousPasswords = "Previous passwords:\n";
        int length = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "";
            Random random= new Random();
            for (int i = length ; i > 0; i--)
            {
                password += availableChars[random.Next(0, availableChars.Length)];
            }
            label1.Text = "Password: " + password;
            previousPasswords += password + "\n";
            label2.Text = previousPasswords;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                length = Convert.ToInt16(textBox1.Text);
            }
            catch
            {
                textBox1.ResetText();
            }
            finally { textBox1.Focus(); }
            
        }
    }
}