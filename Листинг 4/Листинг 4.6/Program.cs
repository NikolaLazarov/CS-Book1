using System;

namespace Листинг_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            char s;
            char [] symbs ={'D', 'M', 'b', 'J', 'q', 'G'};

            Console.WriteLine("Несротиран масив: ");
            for(int k = 0;k<symbs.Length;k++){
                Console.WriteLine(symbs[k]+" ");
            }
            Console.WriteLine();

            for(int i = 0;i<symbs.Length;i++){
                for(int b = 0;b<symbs.Length-b;b++){
                    if(symbs[b] > symbs[b + 1]){
                        s = symbs[b + 1];
                        symbs[b + 1] = symbs[b];
                        symbs[b] = s;
                    }
                }
            }
            Console.WriteLine("Масивът след сортиране: ");
            for (int i = 0; i < symbs.Length; i++)
            {
                Console.WriteLine(symbs[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
