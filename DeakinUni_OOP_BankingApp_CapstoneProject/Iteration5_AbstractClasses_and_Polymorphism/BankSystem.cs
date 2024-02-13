using System;
using System.Collections.Generic;
using System.Text;

namespace Prac6._1
{
    public enum Menuoption
    {
        Create,
        Withdraw,
        Deposit,
        Transfer,
        Print,
        TransactionHistory,
        Quit
    };
    class Banksystem
    {
        static void Main(string[] args)
        {
            Bank bankObject = new Bank();

            //   Account Georgie = new Account("George", 8000.33);
            // Account Lisa = new Account("Lisa", 90000.43);
            Menuoption userSelection;
            do
            {

                userSelection = ReadUserOption();

                switch (userSelection)
                {
                    case Menuoption.Create:
                        CreateAccount(bankObject);
                        break;
                    case Menuoption.Withdraw:
                        DoWithdraw(bankObject);
                        Console.ReadKey();
                        break;
                    case Menuoption.Deposit:
                        DoDeposit(bankObject);
                        break;
                    case Menuoption.Transfer:
                        DoTransfer(bankObject);
                        break;
                    case Menuoption.Print:
                        DoPrint(bankObject);
                        break;
                    case Menuoption.TransactionHistory:
                        DoTransactionHistory(bankObject);
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
            Console.WriteLine("1: Create an account");
            Console.WriteLine("2: Withdraw");
            Console.WriteLine("3: Deposit");
            Console.WriteLine("4: Transfer");
            Console.WriteLine("5: Print");
            Console.WriteLine("6: Transaction History");
            Console.WriteLine("7: Quit");
            Console.WriteLine("Choose an option: 1, 2, 3, 4, 5, 6 and 7 to get the corresponding response.");


            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            return (Menuoption)(number - 1);

        }

        static void DoDeposit(Bank bank)
        {

            Console.WriteLine("Which account would you like to access");
            Account findAccount = FindAccount(bank);
            Console.WriteLine("How much would you like to Deposit.");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            DepositTransaction deposit = new DepositTransaction(findAccount, depositAmount);
            bank.ExecuteTransaction(deposit);
            Console.WriteLine("Would you like to roll back, type \"YES\" or \"NO\" ");
            string decision = Console.ReadLine();
            if(decision.ToUpper() == "YES")
            {

                deposit.Rollback();
                
            }

            deposit.Print();

        }


        static void DoWithdraw(Bank bank)
        {
            Console.WriteLine("Which account would you like to access");
            Account findaccount = FindAccount(bank);
            if (findaccount != null)
            {
                Console.WriteLine("How much would you like to Withdraw.");
                double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                WithdrawTransaction withdraw = new WithdrawTransaction(findaccount, withdrawAmount);
                bank.ExecuteTransaction(withdraw);
                Console.WriteLine("Would you like to roll back, type \"YES\" or \"NO\" ");
                string decision = Console.ReadLine();
                if (decision.ToUpper() == "YES")
                {
                    withdraw.Rollback();
                    
                }
                withdraw.Print();


            }
            else
            {
                Console.WriteLine("Account is not nullvoid!!");
            }
        }


        static void DoPrint(Bank bank)
        {
            Console.WriteLine("Which account would you like to print the details of?");
            Account findaccount = FindAccount(bank);
            if (findaccount != null)
            {

                findaccount.Print();
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }


        }

        static void DoTransfer(Bank bank)
        {
            Console.WriteLine("Which account would you like to access");
            Account fromaccount = FindAccount(bank);
            Console.WriteLine("Which account would you like to transfer too");
            Account toaccount = FindAccount(bank);


            Console.WriteLine("How much would you like to transfer");
            double transferAmount = Convert.ToDouble(Console.ReadLine());

            TransferTransaction transfer = new TransferTransaction(fromaccount, toaccount, transferAmount);
            bank.ExecuteTransaction(transfer);
            Console.WriteLine("Would you like to roll back, type \"YES\" or \"NO\" ");
            string decision = Console.ReadLine();
            if (decision == "YES")
            {

                transfer.Rollback();       
                
            }
            transfer.Print();
        }

        static void CreateAccount(Bank bank)
        {
            string name;
            double startingbalance = 0;


            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What is your registered starting balance?");
            startingbalance = Convert.ToDouble(Console.ReadLine());

            Account account = new Account(name, startingbalance);
            bank.AddAccount(account);

        }



        static Account FindAccount(Bank bank)
        {
            string name;
            name = Console.ReadLine();

            Account myAccount = bank.GetAccount(name);

            if (myAccount != null) // same result dont call function twice
            {
                return myAccount;

            }
            else
            {
                return null;
            }


        }

        static void DoTransactionHistory(Bank bank)
        {
            bank.PrintTransactionHistory();
        }
    }

}
