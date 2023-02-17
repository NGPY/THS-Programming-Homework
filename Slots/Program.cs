using System;

namespace Program
{
    class slots
    {
        public string[] symbols = { "cherry", "bell", "lemon", "orange", "star", "skull" };
        public int[] results = new int[6];
        public int[] scores = new int[6]; // each element corresponds to the same index in the symbols
        public double value = 0;

        public void RollSlots()
        {
            Random n = new Random();
            foreach (int s in results)
            {
                results[s] = n.Next(0, 5);
            }
        }
        public void CheckScores()
        {
            foreach (int n in results)
            {
                switch (n)
                {
                    case 0:
                        scores[0]++;
                        break;
                    case 1:
                        scores[1]++;
                        break;
                    case 2:
                        scores[2]++;
                        break;
                    case 3:
                        scores[3]++;
                        break;
                    case 4:
                        scores[4]++;
                        break;
                    case 5:
                        scores[5]++;
                        break;
                }
            }
        }
        public void CheckValue()
        {
            if (scores[5] == 3)
            {
                value = -1000000000;
            }
            if (scores[5] == 2)
            {
                value = -1;
            }
            if (scores[1] == 3)
            {
                value = 5;
            }
            if (scores[1] == 2)
            {
                value = 1;
            }
            if (scores[0] == 2 || scores[2] == 2 || scores[3] == 2 || scores[4] == 2)
            {
                value = 0.5;
            }
            if (scores[0] == 3 || scores[2] == 3 || scores[3] == 3 || scores[4] == 3)
            {
                value = 1;
            }

        }

    }
}