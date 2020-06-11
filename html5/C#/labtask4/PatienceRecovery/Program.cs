using System;

namespace PatienceRecovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your illness either cold or cancer: ");
            string illness = Console.ReadLine();

            Console.Write("Enter your financial status either rich or poor: ");
            string financialStatus = Console.ReadLine();

            if(illness == "cancer" && financialStatus == "rich")
            {
                Console.Write("Surgery");
            }

            if(illness == "cancer" && financialStatus == "poor")
            {
                Console.Write("Make a public call");
            }

            if(illness == "cold" && financialStatus == "rich")
            {
                Console.Write("take special care");
            }

            if(illness == "cold" && financialStatus == "poor")
            {
                Console.Write("Send home");
            }
            
        }
    }
}
