using System;

namespace AccountProject
{
    class TestAccount
    {
        static void Main(string[] args)
        {


            Account Georgie = new Account("George", 8000.33);

            Console.WriteLine("The current balance is: " + Georgie.getBalance().ToString("C"));

            Console.ReadLine();

            Georgie.Deposit(400); //Deposit 400

            Console.ReadLine();

            Georgie.Withdraw(237); //Withdraw 237

            Console.ReadLine();

            Georgie.Print();

            Console.ReadLine();

        }
    }
}
