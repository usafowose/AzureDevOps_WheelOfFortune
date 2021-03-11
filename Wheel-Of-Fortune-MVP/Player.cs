using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{
    public class Player
    {
        public string playerName;
        public char playerChar;
        public string playerWord;
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
        public void GuessLetter()
        {
            Console.WriteLine("Guess A Letter:");
            playerChar = (char)Console.ReadLine()[0]; 
        }

        public void GuessWord()
        {
            Console.WriteLine("Guess A Word:");
            playerWord = Console.ReadLine();
        }

    }

   

    // Player.GuessLetter()




    //---------
    //interface IGuessedChar
    //{
    //    char guessChar();
    //}

    //interface IGuessedString
    //{
    //    string GuessString(); 
    //}

    //public class Guess: IGuessedChar, IGuessedString
    //{
        
    //}
}

// string playerChar;
// Console.Write("Enter a letter ");
// PlayerChar = Console.ReadLine();
// Console.WriteLine("You entered '{0}'", playerChar);
//