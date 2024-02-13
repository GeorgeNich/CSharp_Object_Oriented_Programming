using System;

namespace _1_2P
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Enter the number (as an integer)");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1) {
                Console.WriteLine("One");
            } else if (number == 2) {
                Console.WriteLine("Two");
            } else if (number == 3) {
                Console.WriteLine("Three");
            } else if (number == 4) {
                Console.WriteLine("Four");
            } else if (number == 5) {
                Console.WriteLine("Five");
            } else if (number == 6) {
                Console.WriteLine("Six");
            } else if (number == 7) {
                Console.WriteLine("Seven");
            } else if (number == 8) {
                Console.WriteLine("Eight");
            
            } else if  (number == 9)
            {
                Console.WriteLine("Nine");
            } else
            {
                Console.WriteLine("This is not a number between 1 and 9");
            }
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
