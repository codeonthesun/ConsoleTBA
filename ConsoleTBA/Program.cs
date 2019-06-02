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

            string playerGreeting = "Welcome, let's start off by Entering your name using the keyboard tool: ";

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

            string playerJewel1 = "RED";

            string playerJewel2 = "GREEN";

            string playerJewel3 = "BLUE";

            string guess = "";

            string hint = "Ow. Sire, please refrain from violently grabbing my finger. Must I remind you, it has to be a jewel. Thank you.";

            string enterPrompt = "Hit Enter to make your choice.";
            
            int guessAmount = 0;

            int guessLimit = 4;

            bool outOfGuesses = false;




            Console.Write(gameTitle);
            ////Console.Write(lineBreaker);
            ////Console.WriteLine();
            Console.Write(playerGreeting);
            playerName = Console.ReadLine();
            Console.Clear();
            Console.Write(gameContinued);
            Console.WriteLine();
            Console.WriteLine("\nThank you! " + playerName + ". You are about to embark on a wonderful adventure. One with many great twists, characters, and events leading to an epic grand finale beyond your wildest imagination! Before we venture forth, I have another less" +
                "\nintrusive question. I have 3 jewels, each vastly different from the other, still equally as beautiful in color." +
                "\nBlue, Green, and Red. " + enterPrompt);

            while (guess != playerJewel1 && !outOfGuesses)

                 {

                if (guessAmount < guessLimit)
                {
                    Console.WriteLine();
                    Console.Write("Which would you like to take with you?: ");
                    guess = Console.ReadLine().ToUpper();
                    guessAmount++;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(hint);
                    Console.ResetColor();
                } else
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
                
                Console.Write("Marverlous choice, you store the jewel in your coin pouch for safe keeping.");
                
            }



            Console.ReadLine();
        }
    }
}
