using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static string Konverzija(string s)
        {
            string output="";
            if (s.EndsWith("AM"))
            {
                string converted = "HH:mm:ss";
                s.Remove(s.Length - 2);
                if (s.StartsWith("12"))
                {
                    s.Replace("12", "00");
                }
                DateTime twentyfourhour = DateTime.Parse(s);
                output = twentyfourhour.ToString(converted);
            }
            else if (s.EndsWith("PM"))
            {
                string convert = "HH:mm:ss";
                int hour = Convert.ToInt32((s.Remove(2)));
                int hourReplacement = hour + 12;
                s.Replace(hour.ToString(), hourReplacement.ToString());
                s.Remove(s.Length - 2);
                DateTime twentyfourhour = DateTime.Parse(s);
                output = twentyfourhour.ToString(convert);
            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Uneti datum");
            string datum = Console.ReadLine();
            Console.WriteLine(Konverzija(datum));
        }
    }
}
