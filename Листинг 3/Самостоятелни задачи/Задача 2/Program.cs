using System;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            
            Console.Write("Въведете  първото цяло число : ");
            n1 = int.Parse(Console.ReadLine());

            
            Console.Write("Въведете второто число цяло число : ");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                Console.WriteLine("Първото число е по-голямо.");
            } 
            else if(n1 < 0 && n2 < 0){
                Console.WriteLine("Моля въведете число.");
            }
            else if(n1 < n2){
                Console.WriteLine("Второто число число е по-голямо.");
            }
            else if(n1 == n2){
                Console.WriteLine("Числата са равни.");
            }
            else{
                Console.WriteLine("Моля въведете число.");
            }
            Console.ReadKey();
        }
    }
}
