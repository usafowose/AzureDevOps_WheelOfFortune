using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{
    public class Player
    {
        public string playerName;

        public Player(string name) 
        {
            playerName = name;
        }

        public string Guess()
        {
            Console.WriteLine("Guess a letter or word:");
            return Console.ReadLine();
        }
    }
}
