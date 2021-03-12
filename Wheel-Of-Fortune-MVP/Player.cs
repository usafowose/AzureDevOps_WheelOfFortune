﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{
    public class Player
    {
        /// <summary>
        /// <c>playerName</c> represents the <c>Player</c> input at the beginning of the game.
        /// </summary>
        public string playerName;

        /// <summary>
        /// <c>playerChar</c> represents the most recent guessed char (<c>Player</c> input)
        /// </summary>
        public char playerChar;

        /// <summary>
        /// not used yet
        /// </summary>
        public string playerWord;

        /// <summary>
        /// not used yet
        /// </summary>
        public string latestGuess;

        public Player(string name)
        {
            playerName = name;
        }

       /* public void MakeAGuess()
        {
            Console.WriteLine("Make A Guess: ");
            var input = Console.ReadLine();
            input.Length == 1 ? (playerChar = Convert.ToChar(input) && latestGuess = "char") : (playerWord = input && "string");
        }
*/
       /// <summary>
       /// Method prompts <c>Player</c> for a letter.
       /// <c>Console.ReadLine</c> accepts first char of <c>Player</c> input and assigns to <c>playerChar</c>
       /// </summary>
        public void GuessLetter()
        {
            Console.WriteLine("Guess A Letter:");
            playerChar = (char)Console.ReadLine()[0];
        }

        public string GuessWord()
        {
            Console.WriteLine("Guess A Word:");
            return Console.ReadLine();
        }

        public string Guess()
        {
            Console.WriteLine("Guess a letter or word:");
            return Console.ReadLine();
        }
    }
}
