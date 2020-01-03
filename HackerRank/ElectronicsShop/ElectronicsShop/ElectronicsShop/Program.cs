using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop
{
    class Program
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int max = 0;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] > max && keyboards[i]+drives[j]<=b) max = keyboards[i] + drives[j];
                }
            }
            if (max == 0) return -1;
            else return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi B N M");
            string[] bnm = Console.ReadLine().Split(' ');
            int b = Convert.ToInt32(bnm[0]);
            int n = Convert.ToInt32(bnm[1]);
            int m = Convert.ToInt32(bnm[2]);
            Console.WriteLine("Popuni cene tastatura");
            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
            Console.WriteLine("Popuni cene usb-ova");
            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
            int result = getMoneySpent(keyboards, drives, b);
            Console.WriteLine($"Potrosila je: {result}");

        }
    }
}
