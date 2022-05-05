using System;

namespace Листинг_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 11,k;
            char[] symbs = new char[size];
            Console.WriteLine("Масив от случайни сумволи:");
            for(k = 0;k<symbs.Length;k++){
                symbs[k] = (char) ('A' + rnd.Next(26));
                Console.Write("| "+symbs[k]+ " ");
            }
            Console.WriteLine("|");
            Console.WriteLine("Масив в обратен ред:");
            for(k=symbs.Length-1;k>=0;k --){
                Console.Write("| "+symbs[k]+" ");
            }
            Console.WriteLine("|");
            Console.ReadKey();
        }
    }
}
