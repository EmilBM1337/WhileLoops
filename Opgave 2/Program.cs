using System;

namespace Opgave_2
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
            int a = 0;

            Console.WriteLine("Jeg kan lægge 5 tal sammen.");
            Console.WriteLine("");

            while (i < 5)
            {
                Console.Write("Indtast et tal: ");
                a += int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("");
            Console.WriteLine("Summen er: " + a);
        }
    }
}
