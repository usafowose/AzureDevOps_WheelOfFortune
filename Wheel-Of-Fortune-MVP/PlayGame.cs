using System;

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
//            }
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

        public static void StartGame()
        {
            RandomGenerator rand = new RandomGenerator();
            Game game1 = new Game(rand);

            Console.WriteLine("Enter your name: ");
            Player player1 = new Player(Console.ReadLine());

            Console.WriteLine($"Welcome {player1.playerName}/t Let's Start!");
            game1.StartGame(); //diff method

            while (!game1.HasWon())
            {
                player1.GuessLetter();
                var charList = game1.CheckCharIndex(player1.playerChar);
                
                if(charList.Count == 0)
                {
                    Console.WriteLine("Letter Not in word please pick again");             
                }
                else
                {
                    game1.ReplaceDash(charList, player1.playerChar);
                }


            }
            Console.WriteLine("Congrats!!!! you've won!!!");
        }

        //public void GetLetter()
        //{
        //    player1.
        //}

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

    
  