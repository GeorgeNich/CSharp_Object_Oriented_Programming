using System;

namespace AccountProject
{
    class Account
    {
        private string _name;
        private double _balance, _amount;

        public Account(string _name, double _balance)
       {
           this._name = _name;
           this._balance =  _balance;
       }
        //Accessor methods
       public string getName()
       {
           return this._name;
       }
       public double getBalance()
       {
           return this._balance;
       }
       //mutator methods
       //Deposit
        public void Deposit(double _amount)
        {
            this._balance += _amount;
            Console.WriteLine("Deposit successful, Accounts new balance is: " + _balance.ToString("C"));
        }
        //Withdraw
        public void Withdraw(double _amount)
        {
            this._balance -= _amount;
            Console.WriteLine("Withdraw successful, Accounts new balance is: " + _balance.ToString("C"));
        }
//Prints the contents of _balance and _name of the account to the terminal.

        public void Print()
        {
            Console.WriteLine("Name: "+ this._name + "\nBalance: " + this._balance);
        }

    }
}
