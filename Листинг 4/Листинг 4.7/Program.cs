using System;

namespace Листинг_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,3,4,8,9};
            char[] symbs = {'a', 'b', 'A', 'B'};
            string[] text = {"червено", "жълто", "бяло"}; 

            Console.WriteLine("Челочислен масив :");
            foreach(int s in nums){
                Console.WriteLine("Числото {0} e {1}",s,s%2==0?"четно" : "нечетно");
            }

            Console.WriteLine("Символен Масив :");
            foreach(char s in symbs){
                Console.WriteLine("Кодът на символ {0} е {1}",s,(int)s);
            }

            Console.WriteLine("Текстов Масив :");
            foreach(string s in text){
                Console.WriteLine("В думата \"{0}\" има {1} букви",s,s.Length);
            }
            
            Console.ReadLine();
        }
    }
}
