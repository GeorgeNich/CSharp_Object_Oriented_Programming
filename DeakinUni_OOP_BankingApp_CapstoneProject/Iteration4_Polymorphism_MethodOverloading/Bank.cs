using System;
using System.Collections.Generic;

namespace Practical5._2
{
    class Bank
    {



        private List<Account> _accounts = new List<Account>();

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

        }

        public void ExecuteTransaction(TransferTransaction transaction)
        {
            transaction.Execute();
        }
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            transaction.Execute();
        }
        public void ExecuteTransaction(DepositTransaction transaction)
        {
            transaction.Execute();
        }


    }
}
