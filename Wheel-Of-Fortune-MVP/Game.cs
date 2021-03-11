using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{
    public class Game
    {
        private string[] words = { "encapsulation", "inheritance", "polymorphism", "abstraction", "composition", "banana"};
        public string TargetWord { get; set; }
        public string DisplayWord { get; set; }
        public RandomGenerator Rand { get; set; }

        public Game(RandomGenerator rand)
        {
            Rand = rand;
        }

        /*public void InputNonCharErrorMessage(var input)
        {
            if (input.TypeOf(String))
            {
                Console.WriteLine("Sorry, you entered a string. Please enter a letter"); 
            } 
            else if (input.TypeOf(Integer))
            {
                Console.WriteLine("Sorry, you entered a number. Please enter a letter");
            }
        }*/

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
                charArray[i] = Char.ToLower(c);
            }
            DisplayWord = new string(charArray);
        }

        //public bool HasWon(string guessedWord)
        //{
        //    return TargetWord == DisplayWord || guessedWord.Equals(TargetWord);
        //}

        public bool HasWon()
        {
            return TargetWord == DisplayWord;
        }
    }
}





