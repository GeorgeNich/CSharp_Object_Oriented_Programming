﻿using System;

namespace Prac6._1
{
    class DepositTransaction : Transaction
    {
        private Account _account;
        private double _amount;
        private bool _executed = false, _success, _reversed;

        bool Executed
        {
            get { return _executed; }
        }

        public bool Success
        {
            get { return _success; }
        }

        bool Reversed
        {
            get { return _reversed; }
        }


        public DepositTransaction(Account account, double amount) : base(amount)
        {
            _account = account;
            _amount = amount;


        }


        /////////////////////////////////////////////////

        override public void Print()
        {
            _account.Print();
            Console.WriteLine("Success: " + _success);
            Console.WriteLine("Reversed: " + _reversed);
            Console.WriteLine("Executed: " + _executed);
            Console.WriteLine("This is a Deposit transaction");

        }



        /// //////////////////////////////////////////////////////////////////////

        public override void Execute()
        {
            
            base.Execute();

            try
            {
                if (_executed == false)
                {

                }
                else
                {
                    throw new InvalidOperationException();
                }
            }

            catch
            {
                Console.WriteLine("Sorry. This transaction has already happened");
                _executed = true;
                return;
            }

            try
            {
                if (_reversed == false)
                {

                }
                else
                {
                    throw new InvalidOperationException();
                }
            }

            catch
            {
                Console.WriteLine("This Deposit has already been reversed");
                _executed = true;
                return;
            }

            try
            {
                if (_success == false)
                {

                }
                else
                {
                    throw new InvalidOperationException();
                }
            }

            catch
            {
                Console.WriteLine("This Depost has already successfully happened");
                return;
            }

            try
            {
                if (_account.Deposit(_amount))//true
                {
                    Console.WriteLine("This Deposit was successful");
                    _success = true;
                    _executed = true;
                }
                else
                {
                    throw new InvalidOperationException();
                } 
            }

            catch
            {
                Console.WriteLine("The Withdrawal of money failed");
                _executed = true;
            }
        }

        ///////////////////////////////////////////////////////////////////
        public override void Rollback()
        {
            base.Rollback();
                
                try
                {
                    if (_reversed == false && _success == true)
                    {
                        _account.Withdraw(_amount);
                        _reversed = true;
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
                catch
                {
                    Console.WriteLine("This transaction has already been reversed or has an invalid success token.");
                }



        }
    }
}