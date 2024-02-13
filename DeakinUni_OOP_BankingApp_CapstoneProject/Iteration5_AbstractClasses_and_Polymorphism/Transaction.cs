using System;
using System.Collections.Generic;
using System.Text;

namespace Prac6._1
{
    abstract class Transaction
    {
        protected double _amount;
        protected bool _success;

        private bool _executed;
        private bool _reversed;
        private DateTime _datestamp;

        public bool Executed
        {
            get { return _executed; }
        }

        public bool Success
        {
            get { return _success; }
        }

       public bool Reversed
        {
            get { return _reversed; }
        }

        public DateTime DateStamp
        {
            
            get { return _datestamp; }
        }

        public Transaction(double amount)
        {
            _amount = amount;

        }

        public abstract void Print();

        public virtual void Execute()
        {
            _datestamp = DateTime.Now;
        }

        public virtual void Rollback()
        {
            _datestamp = DateTime.Now;
        }

    }
}
