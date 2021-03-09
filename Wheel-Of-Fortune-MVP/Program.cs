using System;


namespace Wheel_Of_Fortune_MVP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player Alexandra = new Player();
            Console.WriteLine(Alexandra.playerName);
            Console.WriteLine(Alexandra.GetLetter());
            Console.WriteLine(Alexandra.GetWord());
            
        }
    }
}
