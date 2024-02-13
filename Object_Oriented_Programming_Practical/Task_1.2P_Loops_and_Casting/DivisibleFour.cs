using System;

namespace nloop
{
    class DivisibleFour
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number from 1 - 100: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                
                if (i % 4 == 0 && i % 5 != 0)
                {
                Console.Write(i + " ");
                }


            }   
        }
    }
}

