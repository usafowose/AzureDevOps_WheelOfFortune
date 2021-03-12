using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{
    public class PlayGame
    {
        public void Introduction()
        {
            Console.WriteLine("Welcome to Wheels Of Fortune!");
            Console.WriteLine("You need to guess the letters or even the whole word, and if you get this - you win!");
            Console.WriteLine("Would you like to start the game? Y/N");
            IsStartGame();
        }

        public void IsStartGame()
        {
            string userResponse = Console.ReadLine();
            if (!ValidateIntroduction(userResponse.ToLower()))
            {
                Console.WriteLine("To start the game - input 'y' or 'Y', to quit - 'n' or 'N'.");
                IsStartGame();
            }
            else
            {
                if (userResponse.ToLower() == "n")
                {
                    Console.WriteLine("Ok, bye!");
                    return;
                }
                Play();
            }
        }

        public bool ValidateIntroduction(string yesNo)
        {
            if ((yesNo == "y") || (yesNo == "n"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Play()
        {
            RandomGenerator rand = new RandomGenerator();
            Game game = new Game(rand);

            Console.WriteLine("Enter your name: ");
            Player player = new Player(Console.ReadLine());

            Console.WriteLine($"\nWelcome {player.playerName}!\nLet's Start!");
            game.StartGame();
            Console.WriteLine("This is your word:");
            Console.WriteLine(game.DisplayWord);

            while (!game.DisplayIsTarget())
            {
                string guessedLetter = player.Guess().Trim();
                if (guessedLetter.Length == 1)
                {
                    if (Char.IsLetter(guessedLetter[0]))
                    {
                        var charList = game.CheckCharIndex(guessedLetter[0]);
                        game.ReplaceDash(charList, guessedLetter[0]);
                        Console.WriteLine(game.DisplayWord);
                    }
                    else
                    {
                        Console.WriteLine("Only letters between a-z please");
                        Console.WriteLine(game.DisplayWord);
                    }
                }
                else
                {
                    if (game.HasWon(guessedLetter))
                    {
                        Console.WriteLine("Congratulation!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess, keep playing!");
                        Console.WriteLine(game.DisplayWord);
                    }
                }
            }
            Console.WriteLine("Congrats!!!! You've won!!!");
        }
    }
}
