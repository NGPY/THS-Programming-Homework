// User inputs bet
// User inputs number to bet on
// 
using System;
namespace Program
{
    class Number
    {
        public int n;
        public Number(int n) 
        {
            this.n = n;
        }
        public bool IsEven()
        {
            return n % 2 == 0;
        }
        public bool IsMult10() { return n % 10 == 0;}
        public bool IsPrime()
        {
            if (n == 1 || n == 2) return true;
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
    class Machine
    {
        public double account;
        private double stake = 0;
        // Stakes
        private int even = 2;
        private int mult10 = 3;
        private int prime = 5;
        public Machine(double account) 
        {
            this.account = account;
        }
        public void GameLogic()
        {
            Console.WriteLine("Number to bet on: ");
            Number n = new Number(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Input bet amount: ");
            int bet = Convert.ToInt32(Console.ReadLine());
            int GeneratedNumber;
            Random random= new Random();
            GeneratedNumber = random.Next(1, 30);
            if (GeneratedNumber == n.n)
            {
                stake += 1;
                if (n.IsEven())
                {
                    stake *= even;
                }
                if (n.IsMult10())
                {
                    stake *= mult10;
                }
                if (n.IsPrime())
                {
                    stake *= prime;
                }
                this.account += bet * stake;
            }
            else
            {
                this.account -= bet;
            }
            Console.WriteLine($"Generated number: {GeneratedNumber}\nNumber guessed: {n.n}\nBet: {bet}\nReturns: {bet * stake}");
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Machine test = new Machine(5);
            while (test.account > 0)
            {
                test.GameLogic();
                Console.WriteLine("Account balance: " + test.account);
            }
        }
    }
}