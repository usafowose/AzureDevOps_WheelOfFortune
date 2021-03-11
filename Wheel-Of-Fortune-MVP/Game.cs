using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{

    public class Game
    {
        private string[] words = { "encapsulation", "inheritance", "polymorphism", "abstraction", "composition", "banana"};
        public string TargetWord { get; private set; }
        public string DisplayWord { get; set; }
        public RandomGenerator Rand { get; set; }

        public Game(RandomGenerator rand)
        {
            Rand = rand;
        }

        private string GetRandomTargetWord()
        {
            int randomIndex = Rand.GetNumber(words.Length);
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

        public void StartGame()
        {
            TargetWord = GetRandomTargetWord();
            DisplayWord = PopulateDash(TargetWord);
        }

        public List<int> CheckCharIndex(char c)
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

        public void ReplaceDash(List<int> indexList, char c)
        {
            char[] charArray = DisplayWord.ToCharArray();
            foreach (var i in indexList)
            {
                charArray[i] = c;
            }
            DisplayWord = new string(charArray);
        }

        public bool HasWon(string guessedWord)
        {
            return TargetWord == DisplayWord || guessedWord.Equals(TargetWord);
        }
    }
}





