using System;

namespace Opgave_6
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
                Console.WriteLine("Skriv 1 for at høre noget om køer.");
                Console.WriteLine("Skriv 2 for at få resultatet af 2*4.");
                Console.WriteLine("Skriv 3 for at afslutte programmet.");
                Console.WriteLine("");

                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                if (input == 1)
                {
                    Console.WriteLine("Alle køer stammer fra uroksen. Uroksen var en stor okse, som blev fanget og tæmmet i Sydeuropa for cirka 8.000 år siden. De første køer kom til Danmark for cirka 5.000 år siden.");
                }
                else if (input == 2)
                {
                    Console.WriteLine("2*4=8");
                }
                else if (input == 3)
                {
                    Console.WriteLine("Afslutter programmet....Tryk på en knap for at lukke.");
                    break;
                }
                else
                {
                    Console.WriteLine("Menu");
                }
                Console.WriteLine("");
            }
        }
    }
}
