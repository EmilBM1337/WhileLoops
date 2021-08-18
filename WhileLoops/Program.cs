using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            int i = 0;

            /*
            while (i < 10)
            {
                Console.WriteLine($"While statement {i}");
                i++;
            }
            */
            
            i = 10;
            while (i > 0)
            {
                Console.WriteLine($"While statement {i}");
                i--;
            }
            Console.WriteLine("Denne løkke har kørt 10 gange");
        }
    }
}
