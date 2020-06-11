using System;

namespace AccountTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            Console.WriteLine("Please enter account name: ");
            string name = Console.ReadLine();

            myAccount.Name = name;

            Console.Write($"Your name is {myAccount.Name}");
        }
    }
}
