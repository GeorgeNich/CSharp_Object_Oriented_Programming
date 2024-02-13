using System;

namespace Microwave
{
    class Microwave
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many items will you be heating");
            int items = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Time to heat up one item? (seconds)");
            int time = Convert.ToInt32(Console.ReadLine());

            if (items == 1)
            {
                Console.WriteLine("Recommended time: " + time);
            } else if (items == 2) {
                Console.WriteLine("Reccomended time: " + time*1.5);
            } else if (items == 3) {
                Console.WriteLine("Reccomended time: " + time*2);
            } else
            {
                Console.WriteLine("Please make sure you selected 1,2 or 3 items");
            }
        }
    }
}
