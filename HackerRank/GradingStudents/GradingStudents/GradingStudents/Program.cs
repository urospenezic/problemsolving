using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static int[] gradingStudents(int[] grades)
        {
            // 28 30 28+5= 33 , doci od 33 do 30 somehow. c=5- 8mod5 rounded: number+c; ako c!=0 else samo napisi number.
            // proveriti da li je c >= 3 . ako jeste onda rounduj, ako ne nista
            // proveri da li rounded broj upada u 40+, ako ne nista. ili samo proveri da li je number 38+ realno
            // SAMO ISKODIRAJ OMEGALOL
            int mod =0;
            int rounded=0;
            int[] ispis = new int[grades.Length];
            
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 58)
                {
                    mod = 5 - ((grades[i] % 10) % 5); 
                    if (mod < 3 && mod!=0)
                    {
                        rounded = grades[i] + mod;
                        ispis[i] = rounded;
                    }
                    else
                    {
                        ispis[i] = grades[i];
                    }
                }
                else if (grades[i] < 58)
                {
                    ispis[i] = grades[i];
                }
            }
            return ispis ;

        }

        static void Main(string[] args)
        {
            Random rng = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = rng.Next(0, 100);
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            int[] ispis=gradingStudents(A);
            Console.WriteLine();
            Console.Write(string.Join(" ", ispis));
        }
    }
}
