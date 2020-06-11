using System;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
         
            SavingsAccount saver1 = new SavingsAccount();
            SavingsAccount saver2 = new SavingsAccount();


            saver1.SavingsBalance = 2000.0m;
            saver2.SavingsBalance = 3000.0m;

            SavingsAccount.GetInterst(0.04m);

            Console.WriteLine($"{saver1.CalculateMonthlyInterest()}");
            Console.WriteLine($"{saver2.CalculateMonthlyInterest()}");
           
            SavingsAccount.GetInterst(0.05m);

            Console.WriteLine($"{saver1.CalculateMonthlyInterest()}");
            Console.WriteLine($"{saver2.CalculateMonthlyInterest()} {saver1.SavingsBalance}");

        }
    }
}
