using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Въведете число : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Въведете второ число : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Въведете число, което искате да добавите към сбора на двете числа (1 до 9) : ");
            number = Int32.Parse(Console.ReadLine());
            switch(number){
                case 1:
                Console.WriteLine(n + n1 + 1);
                break;

                case 2:
                Console.WriteLine(n + n1 + 2);
                break;

                case 3:
                Console.WriteLine(n + n1 + 3);
                break;

                case 4:
                Console.WriteLine(n + n1 + 4);
                break;

                case 5:
                Console.WriteLine(n + n1 + 5);
                break;

                case 6:
                Console.WriteLine(n + n1 + 6);
                break;

                case 7:
                Console.WriteLine(n + n1 + 7);
                break;

                case 8:
                Console.WriteLine(n + n1 + 8);
                break;

                case 9:
                Console.WriteLine(n + n1 + 9);
                break;

                default:
                Console.WriteLine("Грешно число.\nПуснете отново програмата и въведете число от 1 до 9.");
                break;
            }
            Console.ReadKey();
        }
    }
}
