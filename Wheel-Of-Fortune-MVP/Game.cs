using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{

    public class Game
    {
        private string[] words = { };
        //public bool HasWon { get; set; }
        public string TargetWord { get; private set; }
        public string DisplayWord { get; set; }

        public Game(string targetWord, string displayWord)
        {
            TargetWord = GetRandomTargetWord();
            DisplayWord = PopulateDash(TargetWord);
            //HasWon = false;
        }

        private string GetRandomTargetWord()
        {
            Random rand = new Random();
            int randomIndex = rand.Next(words.Length);
            return words[randomIndex];
        }

        private string PopulateDash(string word)
        {
            StringBuilder dashedString = new StringBuilder();
            for(int i = 0; i < word.Length; i++)
            {
                dashedString.Append("-");
            }
            return dashedString.ToString();
        }

        private List<int> CheckCharIndex(char c)
        {
            List<int> indexList = new List<int>();

            for (int i = 0; i < TargetWord.Length; i++)
            {
                if (TargetWord[i] == Char.ToLower(c))
                {
                    indexList.Add(i);
                }
            }
            return indexList;
        }

        private void ReplaceDash(List<int> indexList, char c)
        {
            char[] charArray = DisplayWord.ToCharArray();
            foreach (var i in indexList)
            {
                charArray[i] = c;
            }
            DisplayWord = new string(charArray);
        }

        private bool HasWon(string guessedWord)
        {
            return TargetWord == DisplayWord || guessedWord.Equals(TargetWord);
        }
    }
}





