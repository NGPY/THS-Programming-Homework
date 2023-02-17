using System;

namespace Program
{
    class Year
    {
        private int year { get; set; }
        private int[] yearList;
        public Year(int year)
        {
            this.year = year;
            this.yearList = year.ToString()
                .Select(o => Convert.ToInt16(o) - 48)
                .ToArray();
        }
        public bool Repeat()
        {
            int[] count = new int[9];
            foreach (int s in this.yearList)
            {
                count[s]++;
            }
            foreach (int s in count)
            {
                if (s > 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}