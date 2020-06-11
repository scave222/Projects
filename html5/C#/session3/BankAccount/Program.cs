using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {

            
            Console.WriteLine($"Welcome to Polaris Bank");
            Console.WriteLine($"Enter you Name ");

            string newUser = Console.ReadLine();
            Console.WriteLine($"Enter you Intial Balance ");
            decimal initailBalance = Convert.ToDecimal(Console.ReadLine());


            Account account3 = new Account(newUser, initailBalance);


            Console.WriteLine($"Enter your transtaction type Enter 1 for deposit\n and Enter 2 for withdrawal");
            int transaction = int.Parse(Console.ReadLine());

            if (transaction == 1)
            {

                Console.WriteLine($"Pls enter amount to despost ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                account3.desposit(amount);

                Console.WriteLine($"{account3.Name} account has been credited with {amount:C}\n" +
            $"Current balance is now {account3.Balance:C} Thank you for banking with us!");
            }
            if(transaction == 2)
            {
                Console.WriteLine($"Pls enter amount to withdraw ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                string response = account3.withdrawal(amount);
               
                Console.WriteLine($"{response}\nCurrent balance is now {account3.Balance:C} Thank you for banking with us!");
            }



            Console.WriteLine("Would you like to perform another transaction? [Y or N]");

            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                continue;
            }
            else if (answer == "N")
            {
                    Console.WriteLine("Thank you for Banking with Us");
                    return;
            }
            else
            {
                return;
            }

            }
            /*
            Account account1 = new Account("James Shan",2000.0m);
            Account account2 = new Account("Donald Trump", 500000.0m);

            Console.WriteLine($"{account1.Name}'s account balance is {account1.Balance:C}");

            Console.WriteLine($"{account2.Name}'s account balance is {account2.Balance:C}");

            Console.WriteLine($"Pls enter amount to despost ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"adding {amount:C} to {account1.Name} account balance....");
            account1.desposit(amount);

            Console.WriteLine($"{account1.Name} account has been credited with {amount:C}\n" +
                $"Current balance is now {account1.Balance:C} Thank you for banking with us!");
                */
        }
    }
}
