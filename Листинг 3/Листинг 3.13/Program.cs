using System;

namespace Листинг_3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, k = 1, s = 0;

            Console.Write("Сума 1 + 3 + 5 +...+ {0} = ", 2 * 5 - 1);
            for(;k <= n;){
                s += 2 * k - 1;
                k ++;
            }
            System.Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
