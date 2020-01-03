using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignerPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);
        }

        private static int designerPdfViewer(int[] h, string word)
        {
            var helpList = new List<int>();
            foreach (var item in word)
            {
                helpList.Add(h[Math.Abs(item - 'a')]);
            }
            return word.Length * helpList.Max();
        }
    }
}
