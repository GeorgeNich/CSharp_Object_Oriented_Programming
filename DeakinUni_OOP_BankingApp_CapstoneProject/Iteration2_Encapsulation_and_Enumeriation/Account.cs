﻿using System;

namespace Project2
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
        public bool Deposit(double _amount)
        {

            if (_amount < 0)
            {
                return false;
            }
            this._balance += _amount;
            Console.WriteLine("Deposit successful, Accounts new balance is: " + _balance.ToString("C"));
            return true;
        }
        //Withdraw
        public bool Withdraw(double _amount)
        {
            if (_amount > _balance)
            {
                return false;
            }
            this._balance -= _amount;
            Console.WriteLine("Withdraw successful, Accounts new balance is: " + _balance.ToString("C"));
            return true;
        }
//Prints the contents of _balance and _name of the account to the terminal.

        public void Print()
        {
            Console.WriteLine("Name: "+ this._name + "\nBalance: " + this._balance);
        }

    }
}
