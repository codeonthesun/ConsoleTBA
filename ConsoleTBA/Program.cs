using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleTBA
{
    internal class Program

    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string playerName = "";

            string playerGreeting = "I see your sleep has come to an end stranger, woefully time is not our ally. Introductions are not important, so I request you listen closely. If you want to know why you lay in a stone cell waiting death in this decrepit castle. Humble me with your otherwise misguided human trust and sign your name to contract so I may pass on a physical possesion. In the ethereal state I am unable to aid in this plight and your consciousness returns. I fear this close to death experience is one-time catalyst to our communcation.  ";

            string gameTitle = @"███▄    █  ██▓  ▄████  ██░ ██ ▄▄▄█████▓ ██░ ██  ▒█████   ██▓    ▓█████
 ██ ▀█   █ ▓██▒ ██▒ ▀█▒▓██░ ██▒▓  ██▒ ▓▒▓██░ ██▒▒██▒  ██▒▓██▒    ▓█   ▀
▓██  ▀█ ██▒▒██▒▒██░▄▄▄░▒██▀▀██░▒ ▓██░ ▒░▒██▀▀██░▒██░  ██▒▒██░    ▒███
▓██▒  ▐▌██▒░██░░▓█  ██▓░▓█ ░██ ░ ▓██▓ ░ ░▓█ ░██ ▒██   ██░▒██░    ▒▓█  ▄
▒██░   ▓██░░██░░▒▓███▀▒░▓█▒░██▓  ▒██▒ ░ ░▓█▒░██▓░ ████▓▒░░██████▒░▒████▒
░ ▒░   ▒ ▒ ░▓   ░▒   ▒  ▒ ░░▒░▒  ▒ ░░    ▒ ░░▒░▒░ ▒░▒░▒░ ░ ▒░▓  ░░░ ▒░ ░
░ ░░   ░ ▒░ ▒ ░  ░   ░  ▒ ░▒░ ░    ░     ▒ ░▒░ ░  ░ ▒ ▒░ ░ ░ ▒  ░ ░ ░  ░
   ░   ░ ░  ▒ ░░ ░   ░  ░  ░░ ░  ░       ░  ░░ ░░ ░ ░ ▒    ░ ░      ░
         ░  ░        ░  ░  ░  ░          ░  ░  ░    ░ ░      ░  ░   ░  ░";

            string mysteriousVoice = @" __  ____   ______ _____ _____ ____  ___ ___  _   _ ____   __     _____ ___ ____ _____
 |  \/  \ \ / / ___|_   _| ____|  _ \|_ _/ _ \| | | / ___|  \ \   / / _ \_ _/ ___| ____|  _
 | |\/| |\ V /\___ \ | | |  _| | |_) || | | | | | | \___ \   \ \ / / | | | | |   |  _|   (_)
 | |  | | | |  ___) || | | |___|  _ < | | |_| | |_| |___) |   \ V /| |_| | | |___| |___   _
 |_|  |_| |_| |____/ |_| |_____|_| \_\___\___/ \___/|____/     \_/  \___/___\____|_____| (_)";

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

            MethodGameTitle(gameTitle);
            System.Threading.Thread.Sleep(15);
            Console.Clear();
            Console.ResetColor();
            ////////Console.WriteLine(mysteriousVoice);
            ///

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("ARCANE VOICE: ");
            Console.ResetColor();

            //////Console.Write(playerGreeting);

            Console.Write(Wrap1(playerGreeting, 118));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Sign your name to contract and hit ( enter ) if you accept: ");
            Console.ResetColor();

            playerName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(Wrap1("(You groggily lift your arm to your left eye to learn it's now closed and scarred over in blood. You hear several footsteps coming towards your cell. " +
                "With blood on your thumbs neighboring fingers, you sign your name on the cold floor to the sound of your heart racing in fear.) " +
                "As you finish the final character in your signature, the wind chills and the ghost-like entity dissappears. You then faintly hear words in a forgien language to man. " +
                "Below where the voice lingers lay 3 radiant jewels.)", 118));
            Console.ResetColor();
            Console.WriteLine();
            /////////Console.Write(gameContinued);
            Console.WriteLine();
            Console.ReadKey(true);
            Console.Write(lineBreaker);
            /////Console.Write("\nThank you " + playerName + "! You are about to embark on a wonderful adventure. " +
            ////"One with many great twists, characters, and events. All leading to an epic grand finale " +
            ////"beyond your wildest imagination! Before we venture forth, I have another less" +
            ////"\nintrusive question. I have 3 jewels, each vastly different from the other, still equally as beautiful in color.\n");
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
            MethodLimitedAnswerQuestionWithHint(gameOver, journeyPart1, lineBreaker, ref guess, hint, ref guessAmount, guessLimit, ref outOfGuesses);

            Console.ReadLine();
        }

        private static void MethodLimitedAnswerQuestionWithHint(string gameOver, string journeyPart1, string lineBreaker, ref string guess, string hint, ref int guessAmount, int guessLimit, ref bool outOfGuesses)
        {
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
        }

        private static void MethodGameTitle(string gameTitle)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(gameTitle);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("(Text Based Adventure Game.)".PadLeft(48));

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < "Double tap [ spacebar ] to start ".PadLeft(51).Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Double tap [ spacebar ] to start ".PadLeft(51)[i]);
                Console.ResetColor();
                System.Threading.Thread.Sleep(70);
            }

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
            {
            }

            Console.ResetColor();
            Console.ReadKey();
            ////Console.Clear();
            ///
        }

        private static string Wrap1(string text, int max)
        {
            string[] inputLines = text.Replace("\r", string.Empty).Split('\n');
            StringBuilder output = new StringBuilder();

            foreach (string x in inputLines)
            {
                output.Append(Regex.Replace(x, @"(^| +)([^\n]{0," + max + @"}(?![\w\p{P}]))", "$2" + Environment.NewLine, RegexOptions.Multiline));
            }

            return output.ToString();
        }
    }
}