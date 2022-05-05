using System;

namespace Листинг_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = new int[7]{1,3,5,7,6,5,4};
            char [] symbs = new char [] {'A', 'Z', 'B', 'Y'};
            string [] txts = new string[3]{"Едно", "Две", "Три"}; 

            Console.WriteLine("Масив nums :");
            for(int k=0;k<nums.Length;k++){
                Console.Write(nums[k]+" ");
            }
            Console.WriteLine("\nМасив symbs :");
            for(int k=0;k<symbs.Length;k++){
                Console.Write(symbs[k]+" ");
            }
            Console.WriteLine("\nМасив txts :");
            for(int k=0;k<txts.Length;k++){
                Console.Write(txts[k]+" ");
            }
            Console.ReadKey();
        }
    }
}
