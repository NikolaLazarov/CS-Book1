using System;

namespace Листинг_3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, s, n = 10;

            Console.Write("Сума 1 + 3 + 5 +...+ {0} = "  , 2 * n - 1);
            for(k = 1, s = 0; k <= n; s += 2 * k -1, k ++);
            System.Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
