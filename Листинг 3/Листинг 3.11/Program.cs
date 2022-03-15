using System;

namespace Листинг_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, s = 0;

            Console.Write("Сума 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);
            for(int k = 1; k <= n; k ++) {
                s += 2 * k - 1;
            }
            System.Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
