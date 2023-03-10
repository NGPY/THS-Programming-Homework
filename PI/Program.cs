using System.Diagnostics;

namespace Program
{
    class BigMath
    {
        public decimal piTo400 = (decimal)3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964428810975665933446128475648233786783165271201909145648566923460348610454326648213393607260249141273724587006606315588174881520920962829254091715364367892590360011;

        public static string PiNumberFinder(int digitNumber)
        {
            string piNumber = "3,";
            int dividedBy = 11080585;
            int divisor = 78256779;
            int result;

            for (int i = 0; i < digitNumber; i++)
            {
                if (dividedBy < divisor)
                    dividedBy *= 10;

                result = dividedBy / divisor;

                string resultString = result.ToString();
                piNumber += resultString;

                dividedBy = dividedBy - divisor * result;
            }

            return piNumber;
        }
        public static decimal GregoryLeibnizGetPI(int n)
        {
            decimal sum = 0;
            decimal temp = 0;
            for (int i = 0; i < n; i++)
            {
                temp = 4m / (1 + 2 * i);
                sum += i % 2 == 0 ? temp : -temp;
            }
            return sum;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            bool valid = false;
            int n;
            while (!valid)
            {
                try
                {
                    Console.WriteLine("How many digits of pi?");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch { Console.WriteLine("Invalid input!"); continue; }
                break;
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(BigMath.PiNumberFinder(500));
            sw.Stop();
            Console.WriteLine($"Time taken to run: {sw.ElapsedMilliseconds}ms");
            sw.Restart();
            Console.WriteLine(BigMath.GregoryLeibnizGetPI(500));
            sw.Stop();
            Console.WriteLine($"Time taken to run: {sw.ElapsedMilliseconds}ms");
        }
    }
}