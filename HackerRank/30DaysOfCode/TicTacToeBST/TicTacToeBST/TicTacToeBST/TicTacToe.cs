using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeBST
{
    public class TicTacToe
    {
        public char[] board;
        public char userMarker;
        public char aiMarker;
        public char winner;
        public char currentMarker;

        public TicTacToe(char playerToken, char aiToken)
        {
            userMarker = playerToken;
            aiMarker = aiToken;
            winner = '-';
            board = SetBoard();
            currentMarker = userMarker;
        }

        public static char[] SetBoard()
        {
            char[] board = new char[9];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = '-';
            }
            return board;
        }
        public bool PlayTurn(int spot)
        {
            bool isValid = WithingRange(spot) && !IsSpotTaken(spot);
            if (isValid)
            {
                board[spot - 1] = currentMarker;
                currentMarker = (currentMarker == userMarker) ? aiMarker : userMarker;
            }
            return isValid;
        }

        public bool IsSpotTaken(int spot)
        {
            return board[spot - 1] != '-';
        }

        public bool WithingRange(int spot)
        {
            return spot > 0 && spot < board.Length + 1;
        }
        public void PrintBoard()
        {
            Console.WriteLine();
            for (int i = 0; i < board.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("------------------");

                }
                Console.Write(" | " + board[i]);
            }
            Console.WriteLine();
        }
        public void PrintIndexBoard()
        {
            Console.WriteLine();
            for (int i = 0; i < board.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("------------------");

                }
                Console.Write(" | " + (i + 1));
            }
            Console.WriteLine();
        }
        public bool IsThereAWinnder()
        {
            bool diagonalsAndMiddles = (RightDi() || LeftDi() || MiddleRow() || SecondCol()) && board[4] != '-';
            bool topAndFirst = (TopRow() || FirstColum()) && board[0] != '-';
            bool bottomAndThird = (BottomRow() || ThirdColumn()) && board[8] != '-';
            if (diagonalsAndMiddles)
                winner = board[4];
            else if (topAndFirst)
                winner = board[0];
            else if (bottomAndThird)
                winner = board[8];
            return diagonalsAndMiddles || topAndFirst || bottomAndThird;
        }
        //Helper methods for positioning
        #region HelperMethods
        private bool LeftDi()
        {
            return board[2] == board[4] && board[4] == board[6];
        }

        private bool RightDi()
        {
            return board[0] == board[4] && board[4] == board[8];
        }

        private bool ThirdColumn()
        {
            return board[2] == board[5] && board[5] == board[8];
        }

        private bool FirstColum()
        {
            return board[0] == board[3] && board[3] == board[6];
        }

        private bool BottomRow()
        {
            return board[6] == board[7] && board[7] == board[8];
        }

        private bool SecondCol()
        {
            return board[1] == board[4] && board[4] == board[7];
        }

        private bool MiddleRow()
        {
            return board[3] == board[4] && board[4] == board[5];
        }

        private bool TopRow()
        {
            return board[0] == board[1] && board[1] == board[2];
        }
        #endregion


        public bool IsTheBoardFilled()
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == '-')
                    return false;
            }
            return true;
        }

        public string GameOver()
        {
            bool DidSomeoneWin = IsThereAWinnder();
            if (DidSomeoneWin)
                return "We have a winner! The winner is " + winner + "'s";
            else if (IsTheBoardFilled())
                return "Draw: The game is over!";
            else
                return "Not Over!";
        }
    }
}
