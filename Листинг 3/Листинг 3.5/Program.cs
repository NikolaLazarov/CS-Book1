using System;

namespace Листинг_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string name;

            Console.Write("Въведи число до четири :");
            number = Int32.Parse(Console.ReadLine());

            switch(number){
                case 1:
                name ="Единица.";
                Console.WriteLine(name);
                break;

                case 2:
                name = "Двойка.";
                Console.WriteLine(name);
                break;

                case 3:
                name = "Тройка.";
                Console.WriteLine(name);
                break;

                case 4:
                name = "Четворка.";
                Console.WriteLine(name);
                break;

                default:
                name = "Неизвестоно число.";
                Console.WriteLine(name);
                break;
            
            }

            Console.ReadKey();
        }
    }
}
