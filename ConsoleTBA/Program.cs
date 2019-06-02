using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTBA
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = "";

            string playerGreeting = "Welcome, let's start off by (Enter)ing your name using the keyboard tool: ";

            string gameTitle = @"  \  |_ _|  ___| |   |__ __| |   |  _ \  |     ____|
   \ |  |  |     |   |   |   |   | |   | |     __|  
 |\  |  |  |   | ___ |   |   ___ | |   | |     |    
_| \_|___|\____|_|  _|  _|  _|  _|\___/ _____|_____|
                                                    
";

            string gameContinued = @"  ___|  _ \   \  |__ __|_ _|  \  | |   | ____| __ \ 
 |     |   |   \ |   |    |    \ | |   | __|   |   |
 |     |   | |\  |   |    |  |\  | |   | |     |   |
\____|\___/ _| \_|  _|  ___|_| \_|\___/ _____|____/ ";

            string gameOver = @" ____| \   _ _| |     |   |  _ \  ____| | |    \  |  _ \__ __|
 |    _ \    |  |     |   | |   | __|   | |     \ | |   |  |  
 __| ___ \   |  |     |   | __ <  |    _|_|   |\  | |   |  |  
_| _/    _\___|_____|\___/ _| \_\_____|_)_)  _| \_|\___/  _|  
                                                              
  ___|  |   |  ___|  ___| ____|  ___|  ___|  ____| |   | |    
\___ \  |   | |     |     __|  \___ \\___ \  |     |   | |    
      | |   | |     |     |          |     | __|   |   | |    
_____/ \___/ \____|\____|_____|_____/_____/ _|    \___/ _____|";

            string lineBreaker = "###########################################################";

            string jewelRed = "Red";

            string jewelGreen = "Green";

            string jewelBlue = "Blue";

            string guess = "";

            string hint = "You have a feeling these jewels may hold unknown powers and possibly dictate your journey. Choose wisely.";

            string enterPrompt = "Hit (Enter) to make your choice.";

            ////const string format = "{0,-10} {1,10}";


            int guessAmount = 0;

            int guessLimit = 4;

            bool outOfGuesses = false;



            ////Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("test".Length / 2)) + "}", "test"));
            Console.Write(gameTitle);
            ////Console.Write(lineBreaker);
            ////Console.WriteLine();
            Console.Write(playerGreeting);
            playerName = Console.ReadLine();
            Console.Clear();
            Console.Write(gameContinued);
            Console.WriteLine();
            Console.Write("\nThank you! " + playerName + ". You are about to embark on a wonderful adventure. One with many great twists, characters, and events.\nAll leading to an epic grand finale beyond your wildest imagination! Before we venture forth, I have another less" +
                "\nintrusive question. I have 3 jewels, each vastly different from the other, still equally as beautiful in color.\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(jewelBlue + ", ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(jewelGreen + ", ");
            Console.ResetColor();
            Console.Write("and ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(jewelRed + ". ");
            Console.ResetColor();
            Console.Write(enterPrompt);
               

            while (!guess.Contains("GREEN") && !guess.Contains("RED") && !guess.Contains("BLUE") && !outOfGuesses)

                 {

                if (guessAmount < guessLimit)
                {
                    Console.WriteLine();
                    Console.Write("\nWhich would you like to take with you?: ");
                    guess = Console.ReadLine().ToUpper();
                    guessAmount++;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(hint);
                    Console.ResetColor();
                } 




                else
                {
                    outOfGuesses = true;
                    break;
                  
                }
            }

            if (outOfGuesses)
            {
                Console.Clear();
                Console.Write(gameOver);
                Console.WriteLine();
                Console.Write("\nYou are lose! Just kidding, try again and make sure to Enter an appropiate jewel.");

            }
            else
            {
                Console.Clear();
                
                Console.Write("Marverlous choice, you store the " + (guess.ToLower()) + " jewel in your coin pouch for safe keeping.");
                
            }



            Console.ReadLine();
        }
    }
}
