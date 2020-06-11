using System;

namespace oddOrNew
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number");
            }
            else
             {
                  Console.WriteLine($"{number} is an odd number");
            };
        }
        
    }
}
