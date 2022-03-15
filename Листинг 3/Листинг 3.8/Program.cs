using System;

namespace Листинг_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10,s = 0;

            Console.Write("Сума 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);

            while(n>0){
                s+=2*n-1;
                n--;
            }
            System.Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
