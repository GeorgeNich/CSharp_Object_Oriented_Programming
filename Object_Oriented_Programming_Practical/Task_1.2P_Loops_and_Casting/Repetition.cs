using System;

namespace Upperbound
{
    class Repetition
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Enter the upper bound (as an integer)");
            int upperbound = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            double average = 0;
            
            for (int i = 0; i <= upperbound; i++) {
                sum += i;
                average = sum/upperbound;
            }
            Console.WriteLine("Sum is: " + sum);
            Console.WriteLine("Average is: " + average); */

            Console.WriteLine("Enter the upper bound (as an integer)");
            int upperbound = Convert.ToInt32(Console.ReadLine());
            
            double sum = 0;
            double average = 0;

            int i = 0;
            while (i <= upperbound ) {
                sum += i;
                i++;
                average = Convert.ToDouble(sum)/Convert.ToDouble(upperbound);
            }
            
            Console.WriteLine("Sum is: " + sum);
            Console.WriteLine("Average is: " + average); 
            
        }
        
    }
}
