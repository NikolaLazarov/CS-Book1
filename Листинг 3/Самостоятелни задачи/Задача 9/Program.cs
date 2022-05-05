using System;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int S = 0;
            Console.Write("Сума " + 2 * 2 + "+" + 4 * 4 + "+" +  6 * 6 + "+...+ " + n*n + " = ",(n *(n + 1)*(2*n + 1))/6);
            while(n > 0){
                S += (n *(n + 1)*(2*n + 1))/6;
                n --;
            }
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
