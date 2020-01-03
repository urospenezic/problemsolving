using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonApetit
{
    class Program
    {
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int shouldPay = 0;
            int sum = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k) sum += bill[i];
            }
            shouldPay = sum / 2;
            int refund = b - shouldPay;
            if (b > shouldPay) Console.WriteLine(refund);
            else Console.WriteLine("Bon Appetit");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Koji po redu ne jede");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Koliko joj je naplatio?");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Popuni racun:");
            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
            bonAppetit(bill, k, b);
        }
    }
}
