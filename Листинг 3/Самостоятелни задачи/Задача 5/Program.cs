using System;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете ден от седмицата : ");
            string dayweek = Console.ReadLine();

            switch(dayweek) {
                case "Понеделник":
                Console.WriteLine("1");
                break;

                case "Вторник":
                Console.WriteLine("2");
                break;

                case "Сряда":
                Console.WriteLine("3");
                break;

                case "Четвъртък":
                Console.WriteLine("4");
                break;

                case "Петък":
                Console.WriteLine("5");
                break;

                case "Събота":
                Console.WriteLine("6");
                break;

                case "Неделя":
                Console.WriteLine("7");
                break;

                default:
                Console.WriteLine("Невалиден ден.\nСтартирайте програмта отново и въведете ден от седмицата.");
                break;
            }
            Console.ReadKey();
        }
    }
}
