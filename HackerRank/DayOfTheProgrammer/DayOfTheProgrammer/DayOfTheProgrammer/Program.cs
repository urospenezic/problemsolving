using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheProgrammer
{
    class Program
    {
        static string dayOfProgrammer(int year)
        {
            string result = string.Empty;
            int day = 0;
            int firstEightMonths = 243;
            int month = 9;
            if (year >= 1700 && year < 1918)
            {
                if (year % 4 == 0)
                {
                    day = 256 - firstEightMonths - 1;
                    Console.WriteLine(day);
                }
                else day = 256 - firstEightMonths;
            }
            else if (year == 1918)
            {
                day = 31;
                month = 8;
            }
            else
            {
                if (year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
                {
                    day = 256 - firstEightMonths - 1;
                }
                else day = 256 - firstEightMonths;
            }
            result = $"{day}.0{month}.{year}";
            result.Trim();

            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi godinu");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(dayOfProgrammer(year));
        }
    }
}
