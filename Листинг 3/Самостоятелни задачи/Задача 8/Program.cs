using System;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 0;

            Console.Write("Въведете число :");
            int u = int.Parse(Console.ReadLine());

            Console.Write("Въведете второ число :");
            int x = int.Parse(Console.ReadLine());

            if(u > x ){
                while(u > x){
                    u --;
                    S ++;
                    Console.WriteLine(S);
                }
            }
            else if(u < x){
                while(u < x){
                    x --;
                    S ++;
                    Console.WriteLine(S);
                }
            }
            else if(u == x){
                System.Console.WriteLine("Двете числа са равни, стартирайте програмата на ново и въведете две различни числа.");
            }
            Console.ReadKey();
        }
    }
}
