using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hangman
{
    public class Hangman
    {
        public string MysteryWord { get; set; }
        public StringBuilder CurrentGuess { get; set; }
        public List<char> PreviousGuesses { get; set; }
        public int MaxTries { get; set; } = 6;
        public int CurrentTry { get; private set; } = 0;
        public List<string> Dictionary { get; set; }

        public Hangman()
        {
            PreviousGuesses = new List<char>();
            Dictionary = new List<string>();
            IntitializeStreams();
            MysteryWord = PickWord();
            CurrentGuess = InitializeCurrentGuess();
        }

        private StringBuilder InitializeCurrentGuess()
        {
            StringBuilder current = new StringBuilder();
            for (int i = 0; i < MysteryWord.Length * 2; i++)
            {
                if (i % 2 == 0)
                    current.Append("_");
                else
                    current.Append(" ");
            }
            return current;
        }

        internal bool GameOver()
        {
            if(DidWeWin())
            {
                Console.WriteLine("You've won!");
                return true;
            }
            else if(DidWeLose())
            {
                Console.WriteLine("Pepega, you lost. The word was: " + MysteryWord);
                return true;
            }
            return false;
        }

        private bool DidWeLose()
        {
            return CurrentTry >= MaxTries;
        }

        private bool DidWeWin()
        {
            var guess = GetCondensedCurrentGuess();
            return guess.Equals(MysteryWord);
        }

        private string GetCondensedCurrentGuess()
        {
            var guess = CurrentGuess.ToString();
            return guess.Replace(" ", "");
        }

        private string PickWord()
        {
            var random = new Random();
            int wordIndex = Math.Abs(random.Next()) % Dictionary.Count;
            return Dictionary[wordIndex];
        }

        private void IntitializeStreams()
        {
            try
            {
                var query = File.ReadAllLines("MysteryWords.txt");
                Dictionary.AddRange(query);
            }
            catch (Exception)
            {

                throw new FileLoadException();
            }
        }

        internal bool IsGuessedAlready(string guess)
        {
            return PreviousGuesses.Contains(guess[0]);
        }

        internal bool PlayGuess(string guess)
        {
            bool isItAGoodGuess = false;
            for (int i = 0; i < MysteryWord.Length; i++)
            {
                if (MysteryWord[i] == guess[0])
                {
                    CurrentGuess[i * 2] = guess[0];
                    isItAGoodGuess = true;
                    PreviousGuesses.Add(guess[0]);
                }
            }
            if(!isItAGoodGuess)
            {
                CurrentTry++;
            }
            return isItAGoodGuess;
        }

        /// <summary>
        /// " - - - - -\n"+
        //"|        |\n"+
        //"|        O\n" +
        //"|      / | \\ \n"+
        //"|        |\n" +
        //"|       / \\ \n" +
        //"|\n" +
        //"|\n";
        /// </summary>
        /// <returns></returns>
        public string DrawPicture()
        {
            switch(CurrentTry)
            {
                case 0: return NoPersonDraw();
                case 1: return AddHeadDraw();
                case 2: return AddBodyDraw();
                case 3: return AddOneArmDraw();
                case 4: return AddSecondArmDraw();
                case 5: return AddFirstLegDraw();
                default: return FullPersonDraw();
            }
        }
        public string GetFormalCurrentGuess()
        {
            return "Current GUess:" + CurrentGuess.ToString();
        }

        private string AddFirstLegDraw()
        {
            return " - - - - -\n" +
            "|        |\n" +
            "|        O\n" +
            "|      / | \\ \n" +
            "|        |\n" +
            "|       /    \n" +
            "|\n" +
            "|\n";
        }

        private string FullPersonDraw()
        {
            return  " - - - - -\n" +
            "|        |\n" +
            "|        O\n" +
            "|      / | \\ \n" +
            "|        |\n" +
            "|       / \\ \n" +
            "|\n" +
            "|\n";
        }

        private string AddSecondArmDraw()
        {
            return  " - - - - -\n" +
            "|        |\n" +
            "|        O\n" +
            "|      / | \\ \n" +
            "|        |\n" +
            "|       \n" +
            "|\n" +
            "|\n";
        }

        private string AddOneArmDraw()
        {
            return  " - - - - -\n" +
            "|        |\n" +
            "|        O\n" +
            "|      / |  \n" +
            "|        |\n" +
            "|       \n" +
            "|\n" +
            "|\n";
        }

        private string AddBodyDraw()
        {
            return  " - - - - -\n" +
            "|        |\n" +
            "|        O\n" +
            "|        | \n" +
            "|        |\n" +
            "|          \n" +
            "|\n" +
            "|\n";
        }

        private string AddHeadDraw()
        {
           return   " - - - - -\n" +
            "|        |\n" +
            "|        O\n" +
            "|       \n" +
            "|        \n" +
            "|       \n" +
            "|\n" +
            "|\n";
        }

        private string NoPersonDraw()
        {
            return   " - - - - -\n"+
            "|        |\n"+
            "|        \n" +
            "|       \n" +
            "|        \n" +
            "|        \n" +
            "|\n" +
            "|\n";
        }
    }
}
