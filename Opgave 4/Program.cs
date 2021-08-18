using System;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
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
