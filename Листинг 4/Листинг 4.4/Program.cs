using System;

namespace Листинг_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] A = {1,3,5,7,9};
            int [] B,C;
            B=A;
            C=new int[A.Length];
            for(int k = 0;k<A.Length;k++){
                C[k]=A[k];
            }
            A[0]=0;
            B[B.Length-1] = 0;
            Console.WriteLine("A:\tB:\tC:");
            for(int k = 0;k<A.Length;k++){
                Console.WriteLine("{0}\t{1}\t{2}\t", A[k], B[k], C[k]);
            }
            Console.ReadKey();
        }
    }
}
