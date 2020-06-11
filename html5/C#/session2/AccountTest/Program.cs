using System;

namespace AccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            Console.Write("Please enter account name: ");
            string accountName = Console.ReadLine();
            
            myAccount.setName(accountName);

            Console.Write($"The name of this account is {myAccount.getName()}");
             
        }
    }
}
