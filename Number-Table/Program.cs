using System;
namespace Program
{
    //Number table problem
    class NumberTable
    {
        private int naturalNumber;
        private string symbol;
        private int[,] array { get; }
        public NumberTable(int naturalNumber, string symbol)
        {
            this.naturalNumber = naturalNumber;
            this.array = new int[naturalNumber + 1, naturalNumber + 1];
            this.symbol = symbol;
        }
        public string OutputTable()
        {
            string output = "";
            int counter = 0;
            int row = 0;
            foreach (int i in this.array)
            {

                if (counter <= naturalNumber)
                {
                    output += i.ToString() + " ";

                }
                else
                {
                    row++;
                    output += "\n";
                    output += i.ToString() + " ";
                    counter = 0;
                }
                counter++;


            }
            return output;
        }
        public void GenerateTable()
        {
            for (int x = 0; x <= naturalNumber; x++)
            {
                for (int y = 0; y <= naturalNumber; y++)
                {
                    switch (symbol)
                    {
                        case "+":
                            this.array[x, y] = x + y;
                            break;
                        case "-":
                            this.array[x, y] = x - y;
                            break;
                        case "*":
                            this.array[x, y] = x * y;
                            break;
                        case "/":
                            if (x == 0 || y == 0)
                            {
                                this.array[x, y] = 0;
                            }
                            else
                            {
                                this.array[x, y] = x / y;
                            }
                            break;
                    }

                }
            }
        }
    }
}