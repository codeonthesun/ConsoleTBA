using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Figgle;


namespace ConsoleTBA
{
    internal class Program

    {
    
        private static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            string playerName = "";

            

            string playerGreeting = "MyStErIoUs Voice: I see your slumber has come to an end stranger, woefully time is not our ally. If you want to know why you lay in a stone cell waiting death. " +
                "Put your otherwise misguided human trust in me and sign your name to this contract so I may pass on a physical possesion.Currently in my ethereal state, I am unable to help you out of this predicament. " +
                "My current form is non-permanent, your consciousness returns and I fear this near-death experience is the catalyst to our communcation.";

            string gameTitle = "NIGHTHOLE";

            string gameTitle2 = @"";

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

            string journeyPart1 = @"     |  _ \  |   |  _ \   \  | ____|\ \   /    _ \__ __|  _ |
     | |   | |   | |   |   \ | __|   \   /    |   |  |      |
 \   | |   | |   | __ <  |\  | |        |     ___/   |      |
\___/ \___/ \___/ _| \_\_| \_|_____|   _|    _|     _|     _|";

            string lineBreaker = @"______________________________________________________
";

            string jewelRed = "Red";

            string jewelGreen = "Green";

            string jewelBlue = "Blue";

            string guess = "";

            string hint = "You have a feeling these jewels may hold unknown powers and possibly dictate your journey. Choose wisely.";

            string enterPrompt = "Hit (Enter) to make your choice or receive a hint.";

            ////const string format = "{0,-10} {1,10}";

            int guessAmount = 0;

            int guessLimit = 5;

            bool outOfGuesses = false;

            ////Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (gameTitle.Length / 2)) + "}", gameTitle));

            ////////Console.BackgroundColor = ConsoleColor.Yellow;


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                FiggleFonts.SBlood.Render(gameTitle));
            Console.ResetColor();
            Console.WriteLine();
            Console.Write(lineBreaker);
            Console.WriteLine();
            Console.Write(playerGreeting);
            Console.WriteLine();
            Console.Write(string.Format("{0," + ((Console.WindowWidth / 2) + ("Sign your name on the contract and hit (Enter) if you agree: ".Length / 2)) + "}", "Sign your name on the contract and hit (Enter) if you agree: "));
            playerName = Console.ReadLine();
            ////(You groggily lift your arm to your left eye to learn is now closed and scarred over. You hear several footsteps coming towards you. With blood on your thumbs neighboring fingers from your unanswered eye
            ////Wound. You sign your name on the cold floor to the sound of your heart racing.)
            Console.Clear();
            Console.Write(gameContinued);
            Console.WriteLine();
            Console.Write(lineBreaker);
            Console.Write("\nThank you " + playerName + "! You are about to embark on a wonderful adventure. " +
            "One with many great twists, characters, and events. All leading to an epic grand finale " +
            "beyond your wildest imagination! Before we venture forth, I have another less" +
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
                Console.Write(lineBreaker);
                Console.Write("\nYou are lose! Just kidding, try again. " + guessAmount + " failed attempts, are you trying to break a record?");
            }
            else
            {
                Console.Clear();
                Console.Write(journeyPart1);
                Console.WriteLine();
                Console.Write(lineBreaker);
                Console.WriteLine();
                Console.WriteLine("Mysterious Man: Marverlous choice. (you store the " + (guess.ToLower()) + " jewel in your coin pouch for safe keeping.)");
            }

            Console.ReadLine();
        }
    }
}