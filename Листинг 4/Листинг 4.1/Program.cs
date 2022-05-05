using System;

namespace Листинг_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = new int[12];
            for(int k = 0;k<nums.Length;k++){
                nums[k]=3*k+1;
                System.Console.Write("| "+nums[k]+ " ");
            }
            System.Console.WriteLine("|");
            System.Console.ReadKey();
        }
    }
}
