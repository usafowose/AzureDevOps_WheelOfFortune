using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{
    public class Game
    {
        /// <summary>
        /// <c>words</c> is a string array of hardcoded <c>TargetWord</c> candidates
        /// </summary>
        private string[] words = { "encapsulation", "inheritance", "polymorphism", "abstraction", "composition", "banana"};
        
        /// <summary>
        /// <c>TargetWord</c> is a string randomly generated from <c>words</c> array.
        /// </summary>
        public string TargetWord { get; set; }

        /// <summary>
        /// <c>DisplayWord</c> is a string of dashes ('-') mapped to each char of TargetWord.
        /// They will be replaced with letters as they are guessed correctly by the player.
        /// </summary>
        public string DisplayWord { get; set; }

        /// <summary>
        /// Class <c>RandomGenerator</c> is responsible for generating a random integer between 0 and the max index value of <c>words</c> array
        /// </summary>
        public RandomGenerator Rand { get; set; }

        public Game(RandomGenerator rand)
        {
            Rand = rand;
        }

        /// <summary>
        /// Method calls <c>RandomGenerator</c> Class to return a random integer between 0 and max index value of <c>words</c> array.
        /// </summary>
        /// <returns>the string from <c>words</c> array at that integer index</returns>
        private string GetRandomTargetWord()
        {
            int randomIndex = Rand.GetNumber(words.Length);
            return words[randomIndex];
        }

        /// <summary>
        /// Method takes in newly-selected <c>TargetWord</c> and uses <typeparamref>StringBuilder</typeparamref> to create a mutable string of dashes.
        /// </summary>
        /// <param name="word">represents the <c>TargetWord</c></param>
        /// <returns>a string of dashes ('-') the same length as <c>TargetWord</c></returns>
        private string PopulateDash(string word)
        {
            StringBuilder dashedString = new StringBuilder();
            for(int i = 0; i < word.Length; i++)
            {
                dashedString.Append("-");
            }
            return dashedString.ToString();
        }

        /// <summary>
        /// Calls <c>GetRandomTargetWord()</c> and <c>DisplayWord()</c> methods to generate the two strings assigned to <c>TargetWord</c> and <c>DisplayWord</c>
        /// Returns nothing.
        /// </summary>
        public void StartGame()
        {
            TargetWord = GetRandomTargetWord();
            DisplayWord = PopulateDash(TargetWord);
        }

        /// <summary>
        /// <c>TargetWord</c> is checked for
        /// </summary>
        /// <param name="c">the search char</param>
        /// <returns>A List of integers representing the indices where the (lower-cased) search char is found</returns>
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

        /// <summary>
        /// Method takes in List of integers and a char. 
        /// Every integer in List of integers corresponds to an index of <c>DisplayWord</c> that is changed from '-' to the search char.
        /// Newly-created string is assigned to <c>DisplayWord</c>.
        /// Method returns nothing.
        /// </summary>
        /// <param name="indexList">List of integers representing the indices where the search char is found in <c>TargetWord</c></param>
        /// <param name="c">search char</param>
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

        /// <summary>
        /// Method asynchronously checks if all letters of <c>TargetWord</c> have been guessed
        /// </summary>
        /// <returns>Boolean value that breaks game playing loop.</returns>

        public bool HasWon()
        {
            return TargetWord == DisplayWord;
        }
    }
}





