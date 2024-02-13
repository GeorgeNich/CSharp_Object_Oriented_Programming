using System;

namespace helloObjects
{
    class Mobile {
        //instance variables
        private string accType, device, number;
        private double balance, amount, cost, minutes;

        // variables
        private const double CALL_COST = 0.245;
         private const double TEXT_COST = 0.078;


        public Mobile(string accType, string device, string number)
        {
            this.accType = accType;
            this.device = device;
            this.number = number;
            this.balance = 0.0;
        }
        //accessor methods
        public string getaccType()
        {
            return this.accType;
        }
        public string getDevice()
        {
            return this.device;
        }
        public string getNumber()
        {
            return this.number;
        }
        
        //returns the balance as a currency through
        // the ToString method and parameter "C"
        public string getBalance()
        {
            return this.balance.ToString("C");
        }

        //mutator methods
        public void setAccType(string accType)
        {
            this.accType = accType;
        }
        public void setDevice(string device)
        {
            this.device = device;
        }
        public void setNumber(string number)
        {
            this.number = number;
        }
        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        // Methods
        public void addCredit(double amount)
        {
            this.balance += amount;
            Console.WriteLine("Credit added succesfully, new balance " + getBalance());
        }
         public void makeCall(int minutes)
        {
            double cost = minutes * CALL_COST;
            this.balance -= cost;
            Console.WriteLine("call made, new balance: " + getBalance() );

        }
        public void sendText(int numTexts)
        {
            double cost = numTexts * TEXT_COST;
            this.balance -= cost;
           Console.WriteLine("text sent, new balance: " + getBalance() );
        }

    }
}
