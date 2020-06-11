using System;

namespace sum2num
{
    class Program
    {
        static void Main(string[] args)
        {   
            int num1,num2,sum;
            Console.WriteLine("Please enter a number:");
            num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
             num2 = int.Parse(Console.ReadLine());
             sum = num1 + num2 ;
               Console.WriteLine($"The sum is {sum}");
        }
    }
}
