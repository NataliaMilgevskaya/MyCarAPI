namespace Delegates
{
    public delegate void printString (string msg); //declaring a delegate
    internal class Program
    {
        static void Main(string[] args)
        {
            printString del = ColorMsg.PrintGreen;
            del("What color is this text? I hope it's green");

            del = ColorMsg.PrintOrange;
            del("And this text should be orange. Is it? Honesty, it's a little bit yellowish...\n but... It looks like orange if you close your eyes.");

            del = ColorMsg.PrintWhite;
            del("");

        }

        public class ColorMsg
        {
            public static void PrintGreen (string msg)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(msg);
            }

            public static void PrintOrange(string msg)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(msg);
            }

            public static void PrintWhite(string msg)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(msg);
            }
        }

    }
}