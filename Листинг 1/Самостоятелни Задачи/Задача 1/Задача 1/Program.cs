using System;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string namef;

            Console.Write("Как се казвате? ");
            name = Console.ReadLine();

            Console.Write("Каква е фамилията ви? ");
            namef = Console.ReadLine();

            Console.WriteLine("Вие сте "+name+" "+namef+"");
        }
    }
}
