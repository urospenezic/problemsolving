using System;

namespace URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            //replace all empty spaces in string with %20 without helper methods
            var value = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ReplaceAllEmptySpaces(value, number));
            Console.ReadKey();
        }

        //OPTIMAL SOLUTION: traverse the array and find all the spaces. end point of string is number + 2*spaces (she completely ignored the intentional spaces at the end idk why)
        // then do the second loop from number downward and for each character thats not empty space: write that number at end point. EndPoint--
        // when we get to the empty space, do the same as i did
        private static string ReplaceAllEmptySpaces(string value, int number)
        {
            // Uros Penezic%20MonkaW      ;
            // Uros Pen   ;
            value.TrimEnd();
            var arrayForString = value.ToCharArray();
            int numberOfSpacesRequiredToMove = 0;
            for (int i = number; i >= 0; i--)
            {
                if (!char.IsWhiteSpace(arrayForString[i]))
                    numberOfSpacesRequiredToMove++;
                if (char.IsWhiteSpace(arrayForString[i]))
                {
                    for (int j = numberOfSpacesRequiredToMove; j > 0; j--)
                    {
                        arrayForString[i + j + 2] = arrayForString[i + j];
                    }
                    arrayForString[i] = '%';
                    arrayForString[i + 1] = '2';
                    arrayForString[i + 2] = '0';
                }
            }
            return new string(arrayForString);
        }
    }
}
