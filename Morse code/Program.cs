using System.Text.RegularExpressions;

namespace Program
{
    class AlphaNumeric
    {
        private string[] code;
        private string[] morse = new string[] {".-", "-...", "-.-.", "-..",".","..-.", "--.", "....", "..", ".---",
            "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.","-----", "|", ""};
        private string[] alphanumeric = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
            "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8",
            "9", "0", " ", ""};
        public AlphaNumeric(string code)
        {
            this.code = Regex.Split(code, string.Empty);
        }
        public string ToMorse()
        {
            string output = "";
            for (int i = 0; i < this.code.Length; i++)
            {
                output += morse[Array.IndexOf(alphanumeric, this.code[i])];
            }
            return output;
        }
    }
    class MorseCode
    {
        private string[] code;
        private string[] morse = new string[] {".-", "-...", "-.-.", "-..",".","..-.", "--.", "....", "..", ".---",
            "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", ".--", "-..-",
            "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.","-----","|"};
        private string[] alphanumeric = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
            "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8",
            "9", "0", " "};
        public MorseCode(string code)
        {
            this.code = code.Split();
        }
        public string ToAlpha()
        {
            string[] output = new string[this.code.Length];
            for (int i = 0; i < this.code.Length; i++)
            {
                output[i] = alphanumeric[Array.IndexOf(morse, this.code[i])];
            }
            string o = "";
            foreach (string s in output)
            {
                o += s;
            }
            return o;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to: 1. Convert Morse to Alphanumeric, 2. Convert Alphanumeric to Morse");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("input code");
                MorseCode code = new MorseCode(Console.ReadLine());
                Console.WriteLine(code.ToAlpha());
            }
            if (choice == "2")
            {
                Console.WriteLine("input code");
                AlphaNumeric code = new AlphaNumeric(Console.ReadLine());
                Console.WriteLine(code.ToMorse());
            }
        }
    }
}