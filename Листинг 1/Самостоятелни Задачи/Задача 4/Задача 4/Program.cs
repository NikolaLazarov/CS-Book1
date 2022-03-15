using System;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;
            string days;

            Console.Write("Кой месец сме сега? ");
            month = Console.ReadLine();

            Console.Write("Колко дни има в "+month+"? ");
            days = Console.ReadLine();

            Console.WriteLine("В/Във " + month + " има " + days + " дни.");
        }
    }
}
