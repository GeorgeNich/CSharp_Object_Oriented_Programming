using System;
using System.Collections.Generic;
using System.Text;

namespace Prac6._1
{
    class Bank
    {



        private List<Account> _accounts = new List<Account>();
        private List<Transaction> _transactions = new List<Transaction>();



        // add account
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }



        public Account GetAccount(String name)
        {
            // _accounts.find()  LIST find function
            foreach (Account accounts in _accounts)
            {
                if (accounts.getName() == name)
                {

                    return accounts;

                }

            }


            return null;


        }


        public Bank() /////////////////////////////////
        {
            Account account1 = new Account("George", 3000.40);
            Account account2 = new Account("Liza", 8000.40);

            AddAccount(account1);
            AddAccount(account2);

        }

 

        public void ExecuteTransaction(Transaction transaction)
        {

           transaction.Execute();
            _transactions.Add(transaction);

        }

        public void RollbackTranscaction(Transaction transaction)
        {

            transaction.Rollback();
            _transactions.Add(transaction);

        }

       public void PrintTransactionHistory()
        {
            foreach (Transaction item in _transactions)
            {
                item.Print();
                Console.WriteLine("This transaction happened at " + item.DateStamp);
             
            }

        }

        


    }
}

