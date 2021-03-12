using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{
    public class RandomGenerator
    {

        private Random random = new Random();

        /// <summary>
        /// Method generates a random integer between 0 and the length of Game.words string array
        /// </summary>
        /// <param name="maxValue">is the length of the Game.words</param>
        /// <returns>an integer</returns>
        public virtual int GetNumber(int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}
