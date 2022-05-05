using System;
using System.Linq;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число : ");
            var n = double.Parse(Console.ReadLine());

            if(n % 7 == 0 && n % 3 == 0){
                Console.WriteLine("Числото  се дели");
            }
            else {
                Console.WriteLine("Числото не се дели");
            }
            Console.ReadKey();
        }
    }
}
