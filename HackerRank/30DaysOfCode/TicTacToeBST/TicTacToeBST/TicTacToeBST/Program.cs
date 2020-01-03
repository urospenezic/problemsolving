using System;
using System.IO;

namespace TicTacToeBST
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doYouWantToPlay = true;


            while (doYouWantToPlay)
            {
                Console.WriteLine("Welcome to TicTacToe");
                Console.WriteLine("Pick a character that represents you:");
                char playerToken = (char)Console.Read();
                Console.WriteLine("Pick a character for your oponent: ");
                char aiToken = (char)Console.Read();
                var game = new TicTacToe(playerToken, aiToken);
                var ai = new AI();
                // set the game
                Console.WriteLine();
                Console.WriteLine("Now we can start the game!");
                game.PrintIndexBoard();
                while (game.GameOver().Equals("Not Over!"))
                {
                    if (game.currentMarker == game.userMarker)
                    {
                        Console.WriteLine("It's your turn");
                        int spot = Console.Read();
                        while (!game.PlayTurn(spot))
                        {
                            Console.WriteLine("Try again" + spot + " is taken or out of range");
                            spot = Console.Read();
                        }
                        Console.WriteLine($"You picked the {spot}!");
                    }
                    else
                    {
                        Console.WriteLine("It's my turn!");
                        int aiSpot = ai.PickSpot(game);
                        game.PlayTurn(aiSpot);
                        Console.WriteLine($"I picked {aiSpot}!");
                    }
                    //print new board:
                    Console.WriteLine();
                    game.PrintBoard();
                }
                Console.WriteLine(game.GameOver());
                Console.WriteLine();
                // setup a new game
                Console.WriteLine("Do you want another round? Y if yes, N if no");
                char response = (char)Console.Read();
                doYouWantToPlay = response == 'Y';
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
