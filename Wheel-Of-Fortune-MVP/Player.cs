using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{
    class Player
    {
        public string name;
        public char playerChar;
        public string playerWord;


        public Player()
        {
            Console.WriteLine("Enter Name: "); 
            name = Console.ReadLine();
        }
        public char GetLetter()
        {
            Console.WriteLine("Guess A Letter:"); 
            playerChar = Convert.ToChar(Console.Read()); 
            return playerChar;
        }

        public string GetWord()
        {
            Console.WriteLine("Guess A Word:");
            playerWord = Console.ReadLine();
            return playerWord; 
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