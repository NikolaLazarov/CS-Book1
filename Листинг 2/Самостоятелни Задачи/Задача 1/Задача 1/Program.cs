using System;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи число : ");
            var i = int.Parse(Console.ReadLine());

            if (i % 3 == 0)
            {
                Console.WriteLine("Числото се дели.");
            }
            else

            {
                Console.WriteLine("Числото не се дели.");
            }
        }
    }
}
