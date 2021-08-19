using System;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            string input = "";
            while (input != "exit")
            {
                Console.WriteLine("Skriv \"exit\" for at stoppe.");
                input = Console.ReadLine().ToLower();
                if (input == "exit")
                    break;
            }
        }
    }
}
