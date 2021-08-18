using System;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
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
