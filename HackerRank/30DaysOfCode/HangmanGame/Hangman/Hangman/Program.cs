using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hangman! I will pick a word and you will try to guess it");
            Console.WriteLine("If you guess wrong six times, i win");
            Console.WriteLine();
            Console.WriteLine("I have picked my word, below is a picture, and below is your current guess");
            Console.WriteLine("Every time you guess incorrectly, i add a body part of the picture");
            Console.WriteLine();
            bool doYouWantToPlay = true;
            while (doYouWantToPlay)
            {
                Console.WriteLine();
                Console.WriteLine("Alright, let's play!");
                var game = new Hangman();
                do
                {
                    //draw
                    Console.WriteLine();
                    Console.WriteLine(game.DrawPicture());
                    Console.WriteLine();
                    Console.WriteLine(game.GetFormalCurrentGuess());
                    Console.WriteLine(game.MysteryWord);
                    Console.WriteLine();
                    //get the guess
                    Console.WriteLine("Enter a character you think is in the word");
                    var guess = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    //check if the character is guessed already
                    while (game.IsGuessedAlready(guess))
                    {
                        Console.WriteLine("Try again, you've already guessed that character");
                        guess = Console.ReadLine();
                    }
                    if(game.PlayGuess(guess))
                    {
                        Console.WriteLine("Great guess! That character is in the word!");
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately that character isn't in the word");
                    }
                } while (!game.GameOver());
                //keep playing
                Console.WriteLine();
                Console.WriteLine("Do you want to play another round? Y/N");
                var repsonse = Console.ReadLine();
                doYouWantToPlay = repsonse == "Y";
            }
        }
    }
}
