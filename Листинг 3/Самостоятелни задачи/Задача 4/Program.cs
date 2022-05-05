using System;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Въведете число в диапазона 1-7 : ");
            number=Int32.Parse(Console.ReadLine());

            switch(number) {
                case 1:
                Console.WriteLine("Понеделник.");
                break;

                case 2:
                Console.WriteLine("Вторник.");
                break;

                case 3:
                Console.WriteLine("Сряда.");
                break;

                case 4:
                Console.WriteLine("Четвъртък.");
                break;

                case 5:
                Console.WriteLine("Петък.");
                break;

                case 6:
                Console.WriteLine("Събота.");
                break;

                case 7:
                Console.WriteLine("Неделя");
                break;

                default:
                Console.WriteLine("Невалидно число.\nСтартирайте програмта отново и въведете число в диапазона 1-7.");
                break;
            }
            Console.ReadKey();
        }
    }
}
