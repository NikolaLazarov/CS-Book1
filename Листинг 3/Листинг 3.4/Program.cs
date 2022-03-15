using System;

namespace Листинг_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Въведете цяло число до 4 : ");
            number=Int32.Parse(Console.ReadLine());
            if(number == 1){
                System.Console.WriteLine("Единица.");
            }
            else if(number == 2){
                System.Console.WriteLine("Двойка.");
            }
            else if(number == 3) {
                System.Console.WriteLine("Тройка.");
            }
            else if(number == 4) {
                System.Console.WriteLine("Четворка.");
            }
            else {
                System.Console.WriteLine("Невалидно число.");
            }
            
            Console.ReadKey();
        }
    }
}
