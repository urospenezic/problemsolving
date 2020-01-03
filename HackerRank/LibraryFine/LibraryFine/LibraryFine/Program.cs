using System;

namespace LibraryFine
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] d1M1Y1 = Console.ReadLine().Split(' ');

            int d1 = Convert.ToInt32(d1M1Y1[0]);

            int m1 = Convert.ToInt32(d1M1Y1[1]);

            int y1 = Convert.ToInt32(d1M1Y1[2]);

            string[] d2M2Y2 = Console.ReadLine().Split(' ');

            int d2 = Convert.ToInt32(d2M2Y2[0]);

            int m2 = Convert.ToInt32(d2M2Y2[1]);

            int y2 = Convert.ToInt32(d2M2Y2[2]);

            int result = libraryFine(d1, m1, y1, d2, m2, y2);
            Console.WriteLine(result);
        }

        private static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            var timeOne = new DateTime(y1, m1, d1);
            var timeTwo = new DateTime(y2, m2, d2);
            var result = DateTime.Compare(timeOne, timeTwo);
            if (y1 > y2)
                return 10000;
            if (result == 0 || result==-1)
                return 0;
            if (timeOne.Month > timeTwo.Month)
                return (timeOne.Month - timeTwo.Month) * 500;
            if (timeOne.Month == timeTwo.Month)
                return (timeOne.Day - timeTwo.Day) * 15;
            return 0;
            //    2 7 1014
            //1 1 1014
        }
    }
}
