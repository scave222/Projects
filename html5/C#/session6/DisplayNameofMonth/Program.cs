using System;

namespace LoginScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = {"January",
                               "Febuary",
                               "Match",
                               "April",
                               "May",
                               "June",
                               "July",
                               "August",
                               "September",
                               "October",
                               "November",
                               "December"};
        int num = 0;
        while (num <= 12)
        {
            Console.Write("Enter a number from 1 to 12: ");
            num = Convert.ToInt32(Console.ReadLine());
            num -= 1;

         if (num >= 12 || num < 0 )
            {
                break;
            }

            Console.WriteLine($"{months[num]}");
           
        }

       }
    }
}