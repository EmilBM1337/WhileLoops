using System;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            Console.Write("Skriv hvad du vil.... ");
            string input = Console.ReadLine();
            Console.WriteLine("");
            int x = 0;

            while (x < input.Length)
            {
                Console.WriteLine(input.Substring(x, 1));
                x++;
            }
        }
    }
}
