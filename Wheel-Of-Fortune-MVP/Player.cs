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

        public Player()
        {
            Console.WriteLine("Enter Name: "); 
            playerName = Console.ReadLine();
        }

        public char GetLetter()
        {
            Console.WriteLine("Guess A Letter:");        
            return Convert.ToChar(Console.Read());
        }

        public string GetWord()
        {
            Console.WriteLine("Guess A Word:");
            return Console.ReadLine();
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