using System;

namespace Листинг_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string txt = "";

            Console.Write("Въведете просто цяло число от 1 до 9 :");
            number = Int32.Parse(Console.ReadLine());

            switch(number){
                case 1:
                case 9:
                txt = "Вие въведохте нечетно,\nно то не е просто.";
                System.Console.WriteLine(txt);
                break;

                case 2:
                case 3:
                case 5:
                case 7:
                txt = "Вие въведохте просто число.";
                System.Console.WriteLine(txt);
                break;

                case 4:
                case 8:
                txt = "Вие въведохте число - степен на двойката";
                System.Console.WriteLine(txt);
                break;

                case 6:
                txt = "Вие въведохте 6 - съвършено число.";
                System.Console.WriteLine(txt);
                break;

                default:
                txt = "Вие въведохте число различно от 1 до 9 или числото ви е десетично.";
                System.Console.WriteLine(txt);
                break;
            }
            Console.ReadKey();
        }
    }
}
