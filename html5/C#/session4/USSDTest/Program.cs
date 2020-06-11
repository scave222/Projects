using System;

namespace USSDTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("__________  Welcome to Codebits USSD Services __________ \n");
            string response = string.Empty; //this is a local variable
           //anytime you want to execute a statement atleast one, use dowhile loop
            do
            {
                Console.Write("________ MENU ______ \n");
                Console.Write ("1 Airtime\n");
                Console.Write ("2 Data\n");
                Console.Write("3 Transfer\n");
                Console.Write ("______ To Quit Enter y/n\n");

            response = Console.ReadLine();

            if (response=="1")
            {
                Console.Write("Please enter phone number: ");
                long number = Convert.ToInt64(Console.ReadLine());

                
                Console.Write("\n Please enter amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Airtime amount of {amount:C} sent successfully!");

                Console.WriteLine("Would you like to perform another transaction? \ny/Exit to QUIT!!!");
                response = Console.ReadLine();
            }

            }  while (response != "Exit");
        }
    }
}
