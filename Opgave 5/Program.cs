using System;

namespace Opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            while (true)
            {
                Console.WriteLine("Skriv et tal fra 1 til 10 for at stoppe.");
                int input = int.Parse(Console.ReadLine());
                if (input > 0 && input < 11)
                    break;
            }
        }
    }
}
