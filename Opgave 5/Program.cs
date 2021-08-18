using System;

namespace Opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Skriv exit for at stoppe.");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
            }
        }
    }
}
