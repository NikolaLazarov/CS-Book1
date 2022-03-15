using System;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, hundreds;

            Console.Write("Въведете число с повече от 2 цифри : ");
            number = Int32.Parse(Console.ReadLine());

            hundreds = number / 100 % 10;
            string text = "В това число има " + hundreds + " сототици.";

            Console.WriteLine(text);

            
        }
    }
}
