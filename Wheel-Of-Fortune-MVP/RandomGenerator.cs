using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{
    public class RandomGenerator
    {
        private Random random = new Random();

        public virtual int GetNumber(int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}
