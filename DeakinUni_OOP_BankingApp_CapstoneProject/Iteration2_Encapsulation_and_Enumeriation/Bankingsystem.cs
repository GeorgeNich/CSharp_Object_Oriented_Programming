using System;

namespace Project2
{
    public  enum Menuoption{
        Withdraw, 
        Deposit, 
        Print, 
        Quit
    };
    class Banksystem
    {
        static void Main(string[] args)
        {
            Account Georgie = new Account("George", 8000.33);
            Menuoption userSelection;
            do
            {
            
            userSelection = ReadUserOption();

           switch (userSelection)
               {
                   case Menuoption.Withdraw:
                       DoWithdraw(Georgie);
                       Console.ReadKey();
                        break;
                    case Menuoption.Deposit:
                        DoDeposit(Georgie);
                        break;
                        case Menuoption.Print:
                        DoPrint(Georgie);
                        break;
                    case Menuoption.Quit:
                        Console.WriteLine("You've decided to quit.");
                        break;   
                }

            }
            while (userSelection != Menuoption.Quit);


        }
        
        //functions outside of main
    public static Menuoption ReadUserOption() {

            Console.WriteLine("1: Withdraw");
            Console.WriteLine("2: Deposit");
            Console.WriteLine("3: Print");
            Console.WriteLine("4: Quit");
            Console.WriteLine("Choose an option: 1, 2, 3 or 4 to get the corresponding response.");


            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            return (Menuoption)(number - 1);

        }   

       static void DoDeposit(Account account)
       {
           Console.WriteLine("How much would you like to Withdraw.");
           double depositAmount = Convert.ToDouble(Console.ReadLine());
           bool thing = account.Deposit(depositAmount);
           if (thing)
           {
               Console.WriteLine("DoDeposit Successful");
           }else{
               Console.WriteLine("DoDeposit Failed!");
           }
           
       }

        static void DoWithdraw(Account account)
       {
           Console.WriteLine("How much would you like to Withdraw.");
           double withdrawAmount = Convert.ToDouble(Console.ReadLine());
           bool thing = account.Withdraw(withdrawAmount); 
           account.Withdraw(withdrawAmount);
           if (thing)
           {
               Console.WriteLine("DoWithdrawl Successful");
           }else{
               Console.WriteLine("DoWithdrawl Failed!");
           }
       }
       static void DoPrint(Account account)
       {
           account.Print();
       }


    }
    
}
