using PracticalTask5._1;
using System;
using Task4._2;

namespace Project2
{
    public enum Menuoption
    {
        Withdraw,
        Deposit,
        Transfer,
        Print,       
        Quit
    };
    class Banksystem
    {
        static void Main(string[] args)
        {
            Account Georgie = new Account("George", 8000.33);
            Account Lisa = new Account("Lisa", 90000.43);
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
                    case Menuoption.Transfer:
                        DoTransfer(Georgie, Lisa);
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
        public static Menuoption ReadUserOption()
        {

            Console.WriteLine("1: Withdraw");
            Console.WriteLine("2: Deposit");
            Console.WriteLine("3: Transfer");
            Console.WriteLine("4: Print");
            Console.WriteLine("5: Quit");
            Console.WriteLine("Choose an option: 1, 2, 3, 4 and 5 to get the corresponding response.");


            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            return (Menuoption)(number - 1);

        }

        static void DoDeposit(Account account)
        {
            Console.WriteLine("How much would you like to Deposit.");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            DepositTransaction deposit = new DepositTransaction(account, depositAmount);
            deposit.Execute();
            deposit.Rollback();
            deposit.Print();

        }

        static void DoWithdraw(Account account)
        {
            Console.WriteLine("How much would you like to Withdraw.");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            WithdrawTransaction withdraw = new WithdrawTransaction(account, withdrawAmount);
            withdraw.Execute();
            withdraw.Rollback();
            withdraw.Print();
        }

        static void DoPrint(Account account)
        {
            account.Print();
        }

        static void DoTransfer(Account account, Account account2)
        {
            Console.WriteLine("How much would you like to transfer");
            double transferAmount = Convert.ToDouble(Console.ReadLine());


            TransferTransaction transfer = new TransferTransaction(account, account2, transferAmount);
            transfer.Execute();
            transfer.Rollback();
            transfer.Print();
        }


    }

}
