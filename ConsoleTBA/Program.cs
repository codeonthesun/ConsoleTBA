using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Nighthole
{
    internal class Program

    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string playerName = " ";

            string playerGreeting = "   Blimey! At last your wake ends stranger. Woefully time is not our ally, introductions are non-important, so I ask you listen closely. If you want to know why you lay in a stone cell waiting death in this decrepit castle. Humble me with your otherwise misguided human faith, and sign your name to contract so I may pass on a physical possession. In the ethereal state I am unable to aid in this plight and your consciousness returns. I fear this close to death experience is a one-time catalyst to our communication.  ";

            string gameTitle = @" ███▄    █  ██▓  ▄████  ██░ ██ ▄▄▄█████▓ ██░ ██  ▒█████   ██▓    ▓█████
 ██ ▀█   █ ▓██▒ ██▒ ▀█▒▓██░ ██▒▓  ██▒ ▓▒▓██░ ██▒▒██▒  ██▒▓██▒    ▓█   ▀
▓██  ▀█ ██▒▒██▒▒██░▄▄▄░▒██▀▀██░▒ ▓██░ ▒░▒██▀▀██░▒██░  ██▒▒██░    ▒███
▓██▒  ▐▌██▒░██░░▓█  ██▓░▓█ ░██ ░ ▓██▓ ░ ░▓█ ░██ ▒██   ██░▒██░    ▒▓█  ▄
▒██░   ▓██░░██░░▒▓███▀▒░▓█▒░██▓  ▒██▒ ░ ░▓█▒░██▓░ ████▓▒░░██████▒░▒████▒
░ ▒░   ▒ ▒ ░▓   ░▒   ▒  ▒ ░░▒░▒  ▒ ░░    ▒ ░░▒░▒░ ▒░▒░▒░ ░ ▒░▓  ░░░ ▒░ ░
░ ░░   ░ ▒░ ▒ ░  ░   ░  ▒ ░▒░ ░    ░     ▒ ░▒░ ░  ░ ▒ ▒░ ░ ░ ▒  ░ ░ ░  ░";

            string mysteriousVoice = @" __  ____   ______ _____ _____ ____  ___ ___  _   _ ____   __     _____ ___ ____ _____
 |  \/  \ \ / / ___|_   _| ____|  _ \|_ _/ _ \| | | / ___|  \ \   / / _ \_ _/ ___| ____|  _
 | |\/| |\ V /\___ \ | | |  _| | |_) || | | | | | | \___ \   \ \ / / | | | | |   |  _|   (_)
 | |  | | | |  ___) || | | |___|  _ < | | |_| | |_| |___) |   \ V /| |_| | | |___| |___   _
 |_|  |_| |_| |____/ |_| |_____|_| \_\___\___/ \___/|____/     \_/  \___/___\____|_____| (_)";

            string gameContinued = @"  ___|  _ \   \  |__ __|_ _|  \  | |   | ____| __ \
 |     |   |   \ |   |    |    \ | |   | __|   |   |
 |     |   | |\  |   |    |  |\  | |   | |     |   |
\____|\___/ _| \_|  _|  ___|_| \_|\___/ _____|____/ ";

            string gameOverTitle = @" ____| \   _ _| |     |   |  _ \  ____| | |    \  |  _ \__ __|
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

            string gameTitle2 = @" ░ ▒░  ░   ▒ ░ ░   ░ ░  ░  ░▒ ░ ▒░    ░    ▒░▒   ░ ░░▒░ ░ ░  ▒ ░  ░ ▒ ▒░
   ░   ░   ░   ░     ░     ░░   ░   ░       ░    ░  ░░░ ░ ░  ▒ ░░ ░ ░ ▒
    ░        ░       ░  ░   ░               ░         ░      ░      ░ ░  ";

            string lineBreaker = @"______________________________________________________
";

            string jewelRed = "Red";

            string jewelGreen = "Green";

            string jewelBlue = "Blue";

            string guess = "";

            string hint = "(You have a feeling these jewels may hold unknown powers and possibly dictate your journey. Choose wisely.)";

            string enterPrompt = "[ enter ]";

            ////const string format = "{0,-10} {1,10}";

            int guessAmount = 0;

            int guessLimit = 5;

            bool outOfGuesses = false;

            bool gameOver = false;

            ////Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (gameTitle.Length / 2)) + "}", gameTitle));

            ConsoleWindow.QuickEditMode(false);
            MethodGameTitle(gameTitle);
            System.Threading.Thread.Sleep(15);
            Console.Clear();
            Console.ResetColor();
            ////////Console.WriteLine(mysteriousVoice);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("ARCANE VOICE: ");
            Console.ResetColor();
            Console.Write(Wrap1(playerGreeting, 118));
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.Write("   Sign your name and hit ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(enterPrompt);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" if you accept:");
            Console.ResetColor();
            /////playerName = Console.ReadLine();
            ///string playerName = " ";
            do
            {
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                playerName = Console.ReadLine();
                if (!string.IsNullOrEmpty(playerName))
                {
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("   (Sorry, this isn't actually a choice... You MUST sign your name):");
                    ////System.Threading.Thread.Sleep(70);
                    /////Console.Clear();
                }
            } while (string.IsNullOrEmpty(playerName));

            {
                for (int i = 0; i < @"~~".PadLeft(58).Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(@"~~");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(5);
                }

                Console.Write("X");

                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter))
                {
                    break;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n");

            Console.Write(Wrap1("   (Muted and befuddled by the situation, your primary hand reaches to your left eye unconsciously to learn it is now closed and scarred over in blood.", 118));
            Console.ReadKey(); ///Console.WriteLine();
            Console.Write(Wrap1("   You hear several footsteps approaching the cell, scabbards scraping the rough ground behind them.", 118));
            Console.ReadKey(); ///Console.WriteLine();
            Console.Write(Wrap1("   The pain kicks in and suddenly your body tenses with fear and unimaginable sharpness. ", 118));
            Console.ReadKey(); ////Console.WriteLine();
            Console.Write(Wrap1("   Now with blood on your thumbs neighboring fingers, you sign your name on the cold floor to the sound of your heartbeat.", 118));
            Console.ReadKey();/// Console.WriteLine();
            Console.Write(Wrap1("   As you finish the final character in your signature, the ambiance surrounding changes, the wind chills.", 118));
            Console.ReadKey();//// Console.WriteLine();
            Console.Write(Wrap1("   The ghost-like entity disappears and you faintly hear words in a language foreign to you.", 118));
            Console.ReadKey(); ////Console.WriteLine();
            Console.Write(Wrap1("   Below where the voice lingered rest 3 radiant jewels.", 118));
            Console.ReadKey(); /////Console.WriteLine();
            Console.Write(Wrap1("   The first blue as the vast waters encapsulating all that is undiscovered, the second green as Gaia's untampered forests, and the last is a searing red with a powerful aura of recreation through death.)", 118));

            Console.ResetColor();
            /////////Console.Write(gameContinued);
            Console.ReadKey(true);
            /////Console.Write("\nThank you " + playerName + "! You are about to embark on a wonderful adventure. " +
            ////"One with many great twists, characters, and events. All leading to an epic grand finale " +
            ////"beyond your wildest imagination! Before we venture forth, I have another less" +
            ////"\nintrusive question. I have 3 jewels, each vastly different from the other, still equally as beautiful in color.\n");
            //////Console.Write(enterPrompt);
            MethodLimitedAnswerQuestionWithHint(enterPrompt, gameOverTitle, journeyPart1, lineBreaker, ref guess, hint, ref guessAmount, guessLimit, ref outOfGuesses);
            ConsoleWindow.QuickEditMode(false);
            Console.ReadLine();
        }

        private static void MethodLimitedAnswerQuestionWithHint(string enterPrompt, string gameOver, string journeyPart1, string lineBreaker, ref string guess, string hint, ref int guessAmount, int guessLimit, ref bool outOfGuesses)
        {
            while (!guess.Contains("GREEN") && !guess.Contains("RED") && !guess.Contains("BLUE") && !outOfGuesses)

            {
                if (guessAmount < guessLimit)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Write("   Which calls to you? hit ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(enterPrompt);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" to confirm or receive a hint: ");
                    Console.ResetColor();
                    guess = Console.ReadLine().ToUpper();
                    guessAmount++;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n" + hint);
                    Console.WriteLine();
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
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
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

            Console.Write("(Text Based Adventure Game.)".PadLeft(49));

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < "Double tap [ spacebar ] to start ".PadLeft(52).Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Double tap [ spacebar ] to start ".PadLeft(52)[i]);
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

        public static class ConsoleWindow
        {
            private static class NativeFunctions
            {
                public enum StdHandle : int
                {
                    STD_INPUT_HANDLE = -10,
                    STD_OUTPUT_HANDLE = -11,
                    STD_ERROR_HANDLE = -12,
                }

                [DllImport("kernel32.dll", SetLastError = true)]
                public static extern IntPtr GetStdHandle(int nStdHandle); //returns Handle

                public enum ConsoleMode : uint
                {
                    ENABLE_ECHO_INPUT = 0x0004,
                    ENABLE_EXTENDED_FLAGS = 0x0080,
                    ENABLE_INSERT_MODE = 0x0020,
                    ENABLE_LINE_INPUT = 0x0002,
                    ENABLE_MOUSE_INPUT = 0x0010,
                    ENABLE_PROCESSED_INPUT = 0x0001,
                    ENABLE_QUICK_EDIT_MODE = 0x0040,
                    ENABLE_WINDOW_INPUT = 0x0008,
                    ENABLE_VIRTUAL_TERMINAL_INPUT = 0x0200,

                    //screen buffer handle
                    ENABLE_PROCESSED_OUTPUT = 0x0001,

                    ENABLE_WRAP_AT_EOL_OUTPUT = 0x0002,
                    ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004,
                    DISABLE_NEWLINE_AUTO_RETURN = 0x0008,
                    ENABLE_LVB_GRID_WORLDWIDE = 0x0010
                }

                [DllImport("kernel32.dll", SetLastError = true)]
                public static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

                [DllImport("kernel32.dll", SetLastError = true)]
                public static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
            }

            public static void QuickEditMode(bool Enable)
            {
                //QuickEdit lets the user select text in the console window with the mouse, to copy to the windows clipboard.
                //But selecting text stops the console process (e.g. unzipping). This may not be always wanted.
                IntPtr consoleHandle = NativeFunctions.GetStdHandle((int)NativeFunctions.StdHandle.STD_INPUT_HANDLE);
                UInt32 consoleMode;

                NativeFunctions.GetConsoleMode(consoleHandle, out consoleMode);
                if (Enable)
                    consoleMode |= ((uint)NativeFunctions.ConsoleMode.ENABLE_QUICK_EDIT_MODE);
                else
                    consoleMode &= ~((uint)NativeFunctions.ConsoleMode.ENABLE_QUICK_EDIT_MODE);

                consoleMode |= ((uint)NativeFunctions.ConsoleMode.ENABLE_EXTENDED_FLAGS);

                NativeFunctions.SetConsoleMode(consoleHandle, consoleMode);
            }
        }
    }
}