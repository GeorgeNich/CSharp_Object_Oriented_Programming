using System;

namespace Name1_1
{
    class Program1_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is Your name?");
            string name = Console.ReadLine();

            if (name == "George") {
                Console.WriteLine("Welcome back " + name);
            } else if (name == "Dom") {

                Console.WriteLine("Hello Hello " + name + " How are you feeling?");

            } else 
            {
                Console.WriteLine("Hello, I don't believe we've met stranger.");
            }

            
        }
    }
}
