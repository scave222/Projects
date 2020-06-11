using System;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            double num1 = 50.5;
            double num2 = 30.5;
            double results = numbers.Add<double>(num1, num2);
            Console.WriteLine($"{results}");
        }
    }
}
