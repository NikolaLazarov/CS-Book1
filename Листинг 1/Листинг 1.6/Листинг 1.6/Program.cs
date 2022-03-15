using System;

namespace Листинг_1._6
{
    class Program 
    {
        static void Main(string[] args)
        {
            string name;
            Console.Title = "Да се запознаем";
            Console.Write("Как се казвате? ");
            name = Console.ReadLine(); 
            string txt = "Много ми е приятно, "  + name + "!";
            Console.WriteLine(txt);
        }
    }
}
