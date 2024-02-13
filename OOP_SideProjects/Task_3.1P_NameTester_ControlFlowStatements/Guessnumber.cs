using System;

namespace task2
{
    class Program
    {


        public static int target, guess;
        public static bool forever = true; // not used

        public enum Menuoption
        {
            TestNumber,

            GuessThatNumber,

            Quit,
        };

        static void Main()
        {
            Menuoption userSelection;
            target = new Random().Next(100) + 1;
            try
            {
                do
                {

                    userSelection = ReadUserOption();

                    switch (userSelection)
                    {
                        case Menuoption.TestNumber:
                            Console.WriteLine("Number generated, press 2 to guess");
                            GetNumber();
                            break;
                        case Menuoption.GuessThatNumber:
                            GuessNumber();
                            break;
                        case Menuoption.Quit:
                            Console.WriteLine("You've decided to quit.");
                            Console.WriteLine("the number was " + target);
                            break;
                    }

                }
                while (userSelection != Menuoption.Quit);
            }
            catch (FormatException)
            {
                Console.WriteLine("***Please only type integers e.g 11 or 57***");
            }
            finally
            {
                Console.WriteLine("code run");
            }
        }
        
//get number
        public static void GetNumber()
        {
            target = new Random().Next(100);

        }

        
            //guess number
        public static void GuessNumber()
        {
            do
            {
                Console.WriteLine("What is the number youre going to GUESS");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == target)
                {
                    Console.WriteLine("well done you got it correct!");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Try again, guess is too high");
                }
                else if (guess < target)
                {
                    Console.WriteLine("Guess it too low. try again");
                }
            } while (guess != target);
        }
        //read user option input then enum
        public static Menuoption ReadUserOption()
        {
            Console.WriteLine("1: Test Number");
            Console.WriteLine("2: Guess Number");
            Console.WriteLine("3: Giveup(Quit)");
            Console.WriteLine("Choose an option: 1, 2 or 3");


            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            return (Menuoption)(number - 1);


        }
    }
}

