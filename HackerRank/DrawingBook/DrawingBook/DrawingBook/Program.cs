using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {
        static int pageCount(int n, int p)
        {
            int pagesBack = 0;
            int pagesFront = 0;
            if (n % 2 == 0) n++;
            for (int i = n; i >= p || i - 1 == p; i-=2)
            {
                pagesBack++;
            }
            for (int i = 1; i <= p || i-1==p; i+=2)
            {
                pagesFront++;
            }
            pagesBack = pagesBack - 1;
            pagesFront = pagesFront - 1;
            if (pagesFront < pagesBack)
                return pagesFront;
            else return pagesBack;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Uneti broj strana");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Uneti na koju stranu treba da dodje");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join("",pageCount(n,p)));

        }
    }
}
