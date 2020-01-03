using System;
namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
                string result = angryProfessor(k, a);
                Console.WriteLine(result);
            }
        }

        private static string angryProfessor(int k, int[] a)
        {
            int countFolkOnTime = 0;
            if (a.Length < k)
                return "NO";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 0)
                    countFolkOnTime++;
            }
            if (countFolkOnTime >= k)
                return "NO";
            else return "YES";
        }
    }
}
