using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts
{
    class SavingsAccount
    {
        private static decimal annualInterestRate;

        private decimal savingsBalance;

        
        
       public static void GetInterst (decimal rate)
        {
            annualInterestRate = rate;
        }


        public decimal SavingsBalance
        {
            get { return savingsBalance; }
            set
            {
                if (value > 0.00m)
                {
                    savingsBalance = value;
                }

            }
        }
        
        





        public decimal CalculateMonthlyInterest()
        {
            

            return   SavingsBalance + (SavingsBalance * annualInterestRate) / 12;
        }
       
    }
}
