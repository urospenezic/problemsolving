using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeBST
{
    public class AI
    {
        public int PickSpot(TicTacToe game)
        {
            var choices = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                if(game.board[i]=='-')
                {
                    choices.Add(i+1);
                }
            }
            var random = new Random();
            int choice = choices[Math.Abs(random.Next() % choices.Count)];
            return choice;
        }
    }
}
