using System;

namespace Листинг_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете текст :");
            string txt = Console.ReadLine();
            
            if (txt == ""){
                System.Console.WriteLine("Жалко, че не въведохте текст.");
                
            }
            else{
                System.Console.WriteLine("Благодаря, че въведохте текст!");
                if (txt.Length>10){
                    System.Console.WriteLine("Охо, колко много букви!");
                }
                else {
                    System.Console.WriteLine("Охо, колко макво букви!");
                }
            }
            Console.ReadKey();
        }
    }
}
