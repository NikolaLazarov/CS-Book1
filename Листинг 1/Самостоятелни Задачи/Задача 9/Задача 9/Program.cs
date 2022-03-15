using System;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи число : ");
            var num = int.Parse(Console.ReadLine());
            int one = 1;

            Console.WriteLine(""+(num + one)+", "+num+", "+(num - one)+"");
        }
    }
}
