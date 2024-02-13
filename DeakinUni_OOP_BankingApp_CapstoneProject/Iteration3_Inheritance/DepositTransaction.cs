using Project2;
using System;

namespace PracticalTask5._1
{
    class DepositTransaction
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


        public DepositTransaction(Account account, double amount)
        {

            _account = account;
            _amount = amount;


        }


        /////////////////////////////////////////////////

        public void Print()
        {
            _account.Print();
            Console.WriteLine("Success: " + _success);
            Console.WriteLine("Reversed: " + _reversed);
            Console.WriteLine("Executed: " + _executed);
        }



        /// //////////////////////////////////////////////////////////////////////

        public void Execute()
        {

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
        public void Rollback(bool prompt = true)
        {

            if (prompt)
            {
                Console.WriteLine("Would you like to roll back, type \"YES\" or \"NO\" ");
                string decision = Console.ReadLine();

                if (decision == "YES")
                {
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
                else
                {
                    Console.WriteLine("The rollback will not occur");
                }
            }
            else
            {
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
}
