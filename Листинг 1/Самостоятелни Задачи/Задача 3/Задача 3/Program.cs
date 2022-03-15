using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekday;
            string day;
            string month;

            Console.Write("Какъв ден от седмицата е днес? ");
            weekday = Console.ReadLine();

            Console.Write("Кой ден от месеца е днес? ");
            day = Console.ReadLine();

            Console.Write("Кой месец сме? ");
            month = Console.ReadLine();

            Console.WriteLine("Днес сме "+weekday+", "+day+" "+month+".");
        }
    }
}
