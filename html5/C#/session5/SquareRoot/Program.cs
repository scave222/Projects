using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number =Convert.ToDouble(Console.ReadLine());
            double squareRoot = Math.Sqrt(number) + 10;
            Console.WriteLine(squareRoot);
        }
    }
}
