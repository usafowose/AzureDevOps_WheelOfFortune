using System;
using System.Collections.Generic;
using System.Text;

namespace Wheel_Of_Fortune_MVP
{
    public class PlayGame
    {
        /// <summary>
        /// This method holds <c>Console</c> messages that open up our game.
        /// The new user is explained the rules and the given the option to play or exit the game with <c>'y'</c> or <c>'n'</c> command inputs
        /// If <c>'y'</c> the <c>IsStartGame()</c> method is called
        /// </summary>
        public void Introduction()
        {
            Console.WriteLine("Welcome to Wheels Of Fortune!");
            Console.WriteLine("You need to guess the letters or even the whole word, and if you get this - you win!");
            Console.WriteLine("Would you like to start the game? Y/N");
            IsStartGame();
        }

        /// <summary>
        /// Method takes user input and assigns it to a <c>userResponse</c> variable that controls whether to play the game or exit.
        /// <c>userReponse</c> is converted to lower-case for input consistency
        /// </summary>
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

        /// <summary>
        /// Validation method converting user's <c>'y'</c> or <c>'n'</c> response and converting to Boolean value
        /// </summary>
        /// <param name="yesNo"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method holds the main gaming loop. Generating a new <c>TargetWord</c> and prompting <c>player</c> to input guesses until the word has been guessed.
        /// </summary>
        public void Play()
        {
            /// <summary>
            /// <c>rand</c> is assigned to a random integer.
            /// </summary>
            RandomGenerator rand = new RandomGenerator();
            Game game = new Game(rand);

            ///<summary>
            /// New player is prompted for their name on the Console.
            /// The typed input is stored to a <c>player</c> variable.
            ///</summary>
            Console.WriteLine("Enter your name: ");
            Player player = new Player(Console.ReadLine());

            ///<summary>
            /// This renders a brief introduction message and <c>DisplayWord</c> which is a string of dashes ('-') representing the <c>TargetWord</c> that needs to be guessed
            ///</summary>
            Console.WriteLine($"\nWelcome {player.playerName}!\nLet's Start!");
            game.StartGame();
            Console.WriteLine("This is your word:");
            Console.WriteLine(game.DisplayWord);

            ///<summary>
            /// This is the main gaming loop. <c>guessedLetter</c> variable is assigned to the trimmed input string from <c>player</c>.
            /// If <c>guessedLetter</c> has a <c>Length</c> of 1 and is a <c>char</c> Type it is sent to <c>CheckCharIndex</c> method.
            /// If <c>guessedLetter</c> has a <c>Length</c> of 1 and is not a <c>char</c> an error message is sent to the console.
            /// Otherwise <c>guessedLetter</c> is treated like a multi-character string and checked against <c>TargetWord</c>.
            /// If <c>TargetWord</c> is correct, the game ends. Otherwise, this main gaming loop is entered again.
            ///</summary>
            while (!game.DisplayIsTarget())
            {
                string guessedLetter = player.Guess().Trim();
                if (guessedLetter.Length == 1)
                {
                    if (Char.IsLetter(guessedLetter[0]))
                    {
                        var charList = game.CheckCharIndex(guessedLetter[0]);
                        if (charList.Count == 0)
                        {
                            Console.WriteLine("Letter not found in word, try again!!");
                            Console.WriteLine(game.DisplayWord);
                            continue;
                        }
                        game.ReplaceDash(charList, guessedLetter[0]);
                        Console.WriteLine(game.DisplayWord);
                    }
                    else
                    {
                        Console.WriteLine("Only Letters Between A-Z Please");
                        Console.WriteLine(game.DisplayWord);
                    }
                }
                else
                {
                    if (game.HasWon(guessedLetter))
                    {
                        Console.WriteLine("Congratulations!");
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