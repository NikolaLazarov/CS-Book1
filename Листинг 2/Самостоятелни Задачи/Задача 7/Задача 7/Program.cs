using System;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a double number system number :");
                long number = long.Parse(Console.ReadLine());

                Console.WriteLine((number / 100) % 10);
            }
        }
    }
}
