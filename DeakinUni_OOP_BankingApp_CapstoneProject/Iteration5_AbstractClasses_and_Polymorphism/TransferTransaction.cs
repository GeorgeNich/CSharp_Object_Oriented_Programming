using System;

namespace Prac6._1
{
    class TransferTransaction : Transaction
    {
        private Account _fromaccount, _toaccount;
        private double _amount;
        private bool _executed = false, _reversed;
        private WithdrawTransaction _withdraw;
        private DepositTransaction _deposit;




        public TransferTransaction(Account fromaccount, Account toaccount, double amount) : base(amount)
        {

            _amount = amount;
            this._fromaccount = fromaccount;
            this._toaccount = toaccount;

            this._withdraw = new WithdrawTransaction(fromaccount, _amount);
            this._deposit = new DepositTransaction(toaccount, _amount);



        }

        bool Executed
        {
            get { return _executed; }
        }

        /*  bool Success
         {
             get { return _withdraw.Success && _deposit.Success; }
         } */

        public bool Success { get { if (_withdraw.Success && _deposit.Success) { return true; } else { return false; } } }

        bool Reversed
        {
            get { return _reversed; }
        }


        public override void Print()
        {
            _fromaccount.Print();
            _toaccount.Print();
            Console.WriteLine("Success: " + Success);
            Console.WriteLine("Reversed: " + _reversed);
            Console.WriteLine("Executed: " + _executed);
            Console.WriteLine("This is a Transfer transaction");
            Console.WriteLine("Amount:" + _amount + "From account: " + _fromaccount.getName() + "To account: " + _toaccount.getName() );
            

        }

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
                Console.WriteLine("This transaction has already happened");
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
                Console.WriteLine("This Transfer has already been reversed");
                _executed = true;
                return;
            }

            try
            {
                _withdraw.Execute();


                if (_withdraw.Success == false)
                {
                    throw new InvalidOperationException();
                }
            }
            catch
            {
                Console.WriteLine("The transfer has failed");
                _executed = true;
                return;
            }

            try
            {

                _deposit.Execute();

                if (_deposit.Success == false)
                {
                    throw new InvalidOperationException();
                }


            }
            catch
            {

                Console.WriteLine("The deposit side of the transfer has failed");
                _withdraw.Rollback();
                Console.WriteLine("roll back has taken place. withdrawn amount has been refunded ");
                _executed = true;
                return;

            }

            try
            {

                if (Success) //success is true
                {
                    Console.WriteLine("The amount of " + _amount + " has been transfered");
                    _executed = true;
                }
                else
                {
                    throw new InvalidOperationException();
                }



            }
            catch
            {
                return;
            }




        }

        public override void Rollback()
        {
            base.Rollback();

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
                Console.WriteLine("This transfer has already been reversed");
            }

            try
            {
                if (Success == true && Reversed == false)
                {
                    _withdraw.Rollback();
                    _deposit.Rollback();
                    return;
                }
                else
                {
                    throw new InvalidOperationException();
                }

            }
            catch
            {
                Console.WriteLine("the Conditions for this transfer are not valid");
                return;
            }




        }

    }

}