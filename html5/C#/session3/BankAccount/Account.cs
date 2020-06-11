using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Account
    {
        public string Name { get; set; }

        private decimal balance;

        public Account(string name, decimal initiailBalance)
        {
            Name = name;
            Balance = initiailBalance;
        }

        public decimal Balance
        {
            get { return balance; }
           private set { 
                     //if(value > 0.0m)
             if (value == balance) { balance = 0.0m; }
                 balance = value;
                
            }
        }

        public void desposit (decimal amount)
        {
            Balance = Balance + amount;
        }

        public string withdrawal(decimal amount)
        {
              
               if(amount > Balance)
            {
                return "Insufficient balance.";
            }

            Balance = Balance - amount;
            return "Account debited successfully";


        }
    }
}
