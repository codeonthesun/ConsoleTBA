using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Nighthole
{
    internal class Game
    {
        public static void SplashScreen()
        {
            string gameTitle = @" ███▄    █  ██▓  ▄████  ██░ ██ ▄▄▄█████▓ ██░ ██  ▒█████   ██▓    ▓█████
 ██ ▀█   █ ▓██▒ ██▒ ▀█▒▓██░ ██▒▓  ██▒ ▓▒▓██░ ██▒▒██▒  ██▒▓██▒    ▓█   ▀
▓██  ▀█ ██▒▒██▒▒██░▄▄▄░▒██▀▀██░▒ ▓██░ ▒░▒██▀▀██░▒██░  ██▒▒██░    ▒███
▓██▒  ▐▌██▒░██░░▓█  ██▓░▓█ ░██ ░ ▓██▓ ░ ░▓█ ░██ ▒██   ██░▒██░    ▒▓█  ▄
▒██░   ▓██░░██░░▒▓███▀▒░▓█▒░██▓  ▒██▒ ░ ░▓█▒░██▓░ ████▓▒░░██████▒░▒████▒
░ ▒░   ▒ ▒ ░▓   ░▒   ▒  ▒ ░░▒░▒  ▒ ░░    ▒ ░░▒░▒░ ▒░▒░▒░ ░ ▒░▓  ░░░ ▒░ ░
░ ░░   ░ ▒░ ▒ ░  ░   ░  ▒ ░▒░ ░    ░     ▒ ░▒░ ░  ░ ▒ ▒░ ░ ░ ▒  ░ ░ ░  ░";
            Console.Title = "Nighthole";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\n\n\n\n" + gameTitle);
            Console.ResetColor();
            Console.Write("\n\n\n\n\n\n\n\n\n" + "(Text Based Adventure Game.)".PadLeft(49) + "\n\n");
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
            Console.Clear();
        }

        public static string Introduction(string enterPrompt)
        {
            string playerName;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("ARCANE VOICE: ");
            Console.ResetColor();
            Console.Write(Wrap("   Blimey! At last your wake ends stranger. Woefully time is not our ally, introductions are non-important, so I ask you listen closely. If you want to know why you lay in a stone cell waiting death in this decrepit castle. Humble me with your otherwise misguided human faith, and sign your name to contract so I may pass on a physical possession. In the ethereal state I am unable to aid in this plight and your consciousness returns. I fear this close to death experience is a one-time catalyst to our communication", 118));
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n" + "   Sign your name and hit ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(enterPrompt);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" if you accept:");
            Console.ResetColor();
            do
            {
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                playerName = Console.ReadLine();
                if (!string.IsNullOrEmpty(playerName))  // Prevent user from entering empty input as their selected name.
                {
                }
                else
                {
                    Console.Write("\n" + "   (Sorry, this isn't actually a choice... You MUST sign your name):");  // Repeat prompt until a name is given.
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
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)) // Limit user to only Enter key to continue.
                {
                }

                File.AppendAllText("save.txt", playerName); // Create and write playerName to file.
            }
            return playerName;
        }

        public static void Agreement(ref string guess, ref string enterPrompt, ref bool jewelSelected)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(Wrap("\n" + "   (Muted and befuddled by the situation, your primary hand reaches to your left eye unconsciously to learn it is now closed and scarred over in blood.", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   You hear several footsteps approaching the cell, scabbards scraping the rough ground behind them.", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   The pain kicks in and suddenly your body tenses with fear and an unimaginable sharpness.", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   With blood on your thumbs neighboring fingers, you sign your name on the cold floor to the sound of your heartbeat.", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   As you finish the final character in your signature, the ambiance surrounding changes, the wind chills.", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   The ghost-like entity disappears and you faintly hear words in a language foreign to you.", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   Below where the voice lingered rest 3 radiant jewels.", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   The first Blue as the vast waters encapsulating all that is undiscovered, the second a vibrant Green, comparable to Gaia's untampered forests, and the last is a searing Red with a powerful aura of recreation through death.)", 118));
            Console.ResetColor();
            Console.ReadKey(true);
            UserJewelChoiceAndHint(ref jewelSelected, ref enterPrompt, ref guess);
            Console.Clear();
        }

        public static void JourneyPart1(string lineBreaker, string guess)
        {
            Console.Write("\n" + lineBreaker);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(Wrap("\n" + "   (You tightly hold the " + (guess.ToLower()) + " jewel in your hand, blanketing it in your blood.", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   Time appears to speed up, or rather return to it's normal state?", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   You question your sanity, then Like thunder striking, all the sounds abruptly return at once in a painful blow.)", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   Before you can react to the overstimulation of your senses, sharp weaponry prodding and slicing at the door hits your ears.", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   Fatigued, bruised, and confused you survey the area with your eye to find any information.", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   All you see is an empty moss filed stone hell...", 118));
            Console.ReadKey(true);
            Console.Write(Wrap("   Accompanying the 4 large windowless walls, a  metal door standing two men tall with 3 small holes for light to pass.", 118));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            Console.Write(Wrap("   KCKCKCKCKCKCKC~~~ ", 118));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadKey(true);
            Console.Write(Wrap("   Before you can react to the overstimulation of your senses, you hear metal weaponry prodding and slicing at metal door that cage you.)", 118));
            Console.ReadKey(true);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Unknown Bandit: ");
            Console.ResetColor();
            Console.Write("\n" + "Sire? Is that you? It is I, Gracio. I was sent to find you, the queen hastily sent the order when your horse was found limping back to the castle distressed and wounded. thank the stars you are alive. I will free you immediately, the guards have already been dispoed of. The bumbling idiots lie in tent, unsupervised.  ");
            Console.ReadKey(true);
            Program.ConsoleWindow.QuickEditMode(false);
            Console.ReadLine();
        }

        private static string Wrap(string text, int max)
        {
            string[] inputLines = text.Replace("\r", string.Empty).Split('\n');
            StringBuilder output = new StringBuilder();

            foreach (string x in inputLines)
            {
                output.Append(Regex.Replace(x, @"(^| +)([^\n]{0," + max + @"}(?![\w\p{P}]))", "$2" + Environment.NewLine, RegexOptions.Multiline));
            }

            return output.ToString();
        }

        private static void UserJewelChoiceAndHint(ref bool jewelSelected, ref string enterPrompt, ref string playerJewelChoice)
        {
            while (!playerJewelChoice.Contains("GREEN") && !playerJewelChoice.Contains("RED") && !playerJewelChoice.Contains("BLUE")) // Loop until Green, Blue, or Red is received as input from user.

            {
                if (jewelSelected.Equals(false)) // Checking if user has selected a jewel, if not then prompt repeats until they do.
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n" + "   Which calls to you? hit ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(enterPrompt);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" to confirm or receive a hint: ");
                    Console.ResetColor();
                    playerJewelChoice = Console.ReadLine().ToUpper();
                    File.AppendAllText("save.txt", " " + playerJewelChoice.ToLower());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(Wrap("\n" + "   (You have a feeling these jewels hold unknown powers and will possibly dictate your journey. Choose either the Blue, Green, or Red jewel...)", 118));
                    Console.ResetColor();
                }
                else  // Once appropiate jewel is selected, state is updated and user continues forward.
                {
                    jewelSelected = true;

                    break;
                }
            }
        }

        public static void DataTurtle()
        {
            if (File.Exists("save.txt"))
            {
                Console.Title = "Data Turtle";
                char gameDataChoice;
                Console.Write("Salutations, I am the data turtle and if my memory serves correctly you are " + File.ReadAllText("save.txt"));
                Console.Write("?");
                Console.Write("\n" + "Y to Load Game, N to Delete Progress: ");
                gameDataChoice = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (gameDataChoice)
                {
                    case 'Y':
                        Console.Clear();

                        break;

                    case 'N':
                        Console.WriteLine("Progress wiped!");
                        File.Delete("save.txt");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            else
            {
                /// Console.WriteLine("Unfortunately I could not find any save data! :(");
                ///  Console.ReadKey();
                /// Console.Clear();
            }
        }
    }

    internal class Item
    {
    }

    internal class Program

    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string playerName = " ";

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

            string lineBreaker = @"______________________________________________________";

            string playerJewelChoice = " ";

            bool jewelSelected = false;

            string enterPrompt = "[ enter ]";

            bool gameOver = false;

            ConsoleWindow.QuickEditMode(false);
            Game.DataTurtle();
            Game.SplashScreen();
            Game.Introduction(enterPrompt);
            Game.Agreement(ref playerJewelChoice, ref enterPrompt, ref jewelSelected);
            Game.JourneyPart1(lineBreaker, playerJewelChoice);
        }

        public static class ConsoleWindow
        {
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

            private static class NativeFunctions
            {
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

                public enum StdHandle : int
                {
                    STD_INPUT_HANDLE = -10,
                    STD_OUTPUT_HANDLE = -11,
                    STD_ERROR_HANDLE = -12,
                }

                [DllImport("kernel32.dll", SetLastError = true)]
                public static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

                [DllImport("kernel32.dll", SetLastError = true)]
                public static extern IntPtr GetStdHandle(int nStdHandle); //returns Handle

                [DllImport("kernel32.dll", SetLastError = true)]
                public static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
            }
        }

        static public string encrypt(string encryptString)
        {
            string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
            });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        static public string Decrypt(string cipherText)
        {
            string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            cipherText = cipherText.Replace(" ", "+");

            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
            });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}