using System;

namespace GuessingGame
{
    class GuessingNumber
    {
        static void Main(string[] args)
        {
            try
            {
            int number = 5;
            int guess = 0;
            while (guess != number)
            {
            Console.WriteLine("Guess a number from 1 - 10");
            guess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have guessed the number! Well done!");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
