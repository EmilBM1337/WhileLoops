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
                input = Console.ReadLine().ToLower();
                if (input == "exit")
                    break;
            }
        }
    }
}
