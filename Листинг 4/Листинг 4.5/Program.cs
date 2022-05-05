using System;

namespace Листинг_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, index;
            int size = 15;
            Random rnd = new Random();
            int [] nums = new int[size];
            for(int k = 0;k<nums.Length;k++){
                nums[k] = rnd.Next(1,101);
                Console.Write(nums[k]+" ");
            }
            System.Console.WriteLine();
            index = 0;
            value = nums[index];
            for(int k = 0;k<nums.Length;k++){
                if(nums[k]>value){
                    value=nums[k];
                    index=k;
                }
            }
            Console.WriteLine("Най-голямата стойност: "+value);
            System.Console.WriteLine("Индекс на елемента: "+index);
            System.Console.ReadKey();
        }
    }
}
