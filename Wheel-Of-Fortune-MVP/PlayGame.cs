using System;
using System.Collections.Generic;

namespace Wheel_Of_Fortune_MVP
{
    public class PlayGame
    {
//        public static void Introduction()
//        {
//            Console.WriteLine("Welcome to Wheels Of Fortune!");
//            Console.WriteLine("You need to guess the letters or even the whole word, and if you get this - you will know who we are ;)");
//            Console.WriteLine("Would you like to start the game? Y/N");
//            IsStartGame();
//        }

//        public static void IsStartGame()
//        {
//            string userResponse = Console.ReadLine();
//            if (!ValidateIntroduction(userResponse.ToLower()))
//            {
//                Console.WriteLine("To start the game - input 'y' or 'Y', to quit - 'n' or 'N'.");
//                IsStartGame();
//            }
//            else
//            {
//                if (userResponse.ToLower() == "n")
//                {
//                    Console.WriteLine("Ok, bye!");
//                    return;
//                }
//                StartGame();
//            }git stat
//        }

//        public bool ValidateIntroduction(string yesNo)
//        {
//            if (yesNo.Length != 1 || yesNo != "y" || yesNo != "n")
//            {
//                return false;
//            }
//            else
//            {
//                return true;
//            }
//        }

        //public void PlayGame()
        //{
        //    RandomGenerator rand = new RandomGenerator();
        //    Game game = new Game(rand);

        //    Console.WriteLine("Enter your name: ");
        //    Player player = new Player(Console.ReadLine());

        //    Console.WriteLine(player1.playerName); //Andrew
        //}

        /// <summary>
        /// Method begins the game
        /// </summary>
        public static void StartGame()
        {
            /// <summary>
            /// <c>rand</c> is assigned to a random integer.
            /// </summary>
            RandomGenerator rand = new RandomGenerator();

            ///<summary>
            ///<c>game1</c> is instantiated with the newly-generated <c>rand</c> integer
            ///</summary>
            Game game1 = new Game(rand);

            ///<summary>
            /// New player is prompted for their name on the Console.
            /// The typed input is stored to a <c>player1</c> variable.
            ///</summary>
            Console.WriteLine("Enter your name: ");
            Player player1 = new Player(Console.ReadLine());

            ///<summary>
            /// <c>player1</c> is welcomed to the game
            ///</summary>
            Console.WriteLine($"Welcome {player1.playerName}!\nLet's Play Wheel ~ Of ~ Fortune!!! ~ ~ ~");

            ///<summary>
            /// This method initializes the <c>TargetWord</c> and <c>DisplayWord</c> for the game
            ///</summary>
            game1.StartGame();

            // Console.WriteLine($"\n\n{game1.TargetWord}");

            /// <summary>
            /// <c>game1.HasWon()</c> is an asynchronous method returning a boolean value in regard to the win/not won state of the game.
            /// Until <c>game1</c> is won, <c>player1</c> is placed in a gaming loop that continues to request letters and replace <c>DisplayWord</c> dashes 
            /// until all the letters have been guessed.
            /// </summary>
            while (game1.HasWon() == false)
            {
                player1.GuessLetter();
                List<int> charList = game1.CheckCharIndex(player1.playerChar);
                
                if(charList.Count == 0)
                {
                    Console.WriteLine("Uh-Oh. Letter is not in word. Please pick again:");             
                }
                else
                {
                    game1.ReplaceDash(charList, player1.playerChar);
                    Console.WriteLine(game1.DisplayWord);
                }
            }
            Console.WriteLine("Congratulations!!!! You've won!!!");
        }
    } 
}

//-----
/**
        Player player1 = new Player();
Game game1 = new Game();
hasWon = game1.hasWon;

while hasWon == false{

    Game.StartGame();

    charGuessed = player1.guessLetter();
**/

    //start game udates targetWORD and DisplayWord
    // calls GetRandomTargetWord and DisplayWord

    
  