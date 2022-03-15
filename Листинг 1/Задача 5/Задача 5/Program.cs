using System;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Коя година сте родени? ");
            var yearb = int.Parse(Console.ReadLine());
            

            Console.Write("Коя година сме в момента? ");
            var yearn = int.Parse(Console.ReadLine());


            Console.WriteLine("Вие сте на "+(yearn - yearb)+"");
        }
    }
}
