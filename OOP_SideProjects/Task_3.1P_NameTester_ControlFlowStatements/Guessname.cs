using System;

namespace task1
{
    class Program
    {

        public static string thename, getnamestring;
        public static bool forever = true; // not used

        public enum Menuoption
        {
            TestName,

            GuessThatName,

            Quit,
        };

        static void Main()
             {
                try{
                
                Menuoption userSelection;
                 do
                 {

                     userSelection = ReadUserOption();

                    switch (userSelection)
                    {
                        case Menuoption.TestName:
                            Console.WriteLine("What is the name that you wanted?");
                            GetName();
                             break;

                         case Menuoption.GuessThatName:
                             GuessName();
                             break;
                         case Menuoption.Quit:
                             Console.WriteLine("You've decided to quit.");
                             Console.WriteLine("the name was " + thename);
                             break;   
                     }

                 }
                 while (userSelection != Menuoption.Quit);
             } catch (FormatException)
             {
                 Console.WriteLine("Use only numbers for the selection phase");
             }
             }

        
        //functions
    public static void GetName()
    {
        thename = Console.ReadLine();
        foreach (char x in thename)             
        {
            if (char.IsDigit(x))
            {
                Console.Write("Numbers are not allowed please only enter letters\n");  
            }
            break;
        }
    
    }


        public static void GuessName()
        {
            do{
            Console.WriteLine("What is the name youre going to GUESS");
            getnamestring = Console.ReadLine();
            if (getnamestring == thename)
            {
                Console.WriteLine("well done you got it correct!");
            }
            else
            {
                Console.WriteLine("Try again");
            }

        } while (getnamestring != thename);
        }


        //read user option input then enum
        public static Menuoption ReadUserOption()
        {
            Console.WriteLine("1: Input Name");
            Console.WriteLine("2: Guess Name");
            Console.WriteLine("3: Giveup(Quit)");
            Console.WriteLine("Choose an option: 1, 2 or 3");


            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            return (Menuoption)(number - 1);


        }
    }
}

