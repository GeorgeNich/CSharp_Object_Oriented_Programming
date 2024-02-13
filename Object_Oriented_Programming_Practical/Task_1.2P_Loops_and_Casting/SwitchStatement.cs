using System;

namespace SwitchStatement
{
    class SwitchStatement
    {
        public static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Enter the number (as an integer)");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number) {
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                // missing lines to be completed
                
                
                default: Console.WriteLine("Number has to be between 1 and 9"); break;
            }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            }
     }
    
}

