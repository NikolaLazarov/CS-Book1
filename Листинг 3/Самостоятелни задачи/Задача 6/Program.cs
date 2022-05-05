using System;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 0,n = 10;
            
            Console.Write("Сума 2 + 4 + 6 +...+ " + n*n + "=", n * (n + 1));
             while(n>0){
                S += n * (n + 1);
                n --;
            }
            System.Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
