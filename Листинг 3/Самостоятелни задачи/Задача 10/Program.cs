using System;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int W = 0;

            Console.Write("Въведете число :");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Въведете второ число :");
            int z = int.Parse(Console.ReadLine());

            if(l % 5 == 2 && z % 3 == 1){
                Console.WriteLine(W += z + l);
            }
            Console.ReadKey();
        }
    }
}
