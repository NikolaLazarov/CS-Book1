using System;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;

            Console.Write("Как се казвате? ");
            name = Console.ReadLine();

            Console.Write("На колко сте години? ");
            age = Console.ReadLine();

            Console.WriteLine("Вие сте "+name+" и сте на "+age+" години.");

        }
    }
}
