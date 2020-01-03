using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocksMarket
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            int sum = 0;
            List < int > arr= ar.ToList();
            for (int i = arr.Count-1; i >=1; i--)
            {
                for (int j = i-1; j >=0 ; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        sum++;
                        arr.RemoveAt(i);
                        i = arr.Count - 1;
                        arr.RemoveAt(j);
                        break;
                    }
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.WriteLine("Number of socks?");
            int n = int.Parse(Console.ReadLine());
            int[] socks = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            for (int i = 0; i < n; i++)
            {
                //socks[i] = rng.Next(1, 10);
                Console.Write(socks[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(string.Join("",sockMerchant(n,socks)));

        }
    }
}
