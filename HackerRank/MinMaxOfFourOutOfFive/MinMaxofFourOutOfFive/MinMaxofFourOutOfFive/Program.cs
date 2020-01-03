using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxofFourOutOfFive
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            long sumCurrent = 0;
            long sumMin = int.MaxValue;
            long sumMax = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    sumCurrent += arr[j];
                    Console.WriteLine($"Current se menja za {arr[j]} na {sumCurrent}");
                }
                sumCurrent -= arr[i];
                Console.WriteLine($"Iz currenta se izbacuje {i}ti element i current je {sumCurrent}");
                if (sumMin >= sumCurrent) { sumMin = sumCurrent; Console.WriteLine(); }
                if (sumCurrent > sumMax) { sumMax = sumCurrent;}
                sumCurrent = 0;
            }
            Console.Write(sumMin + " " + sumMax);
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            //long n = long.Parse(Console.ReadLine());
            int[] arr = new int[] { 793810624, 895642170, 685903712, 623789054, 468592370 };
            
            miniMaxSum(arr);
        }
    }
}
