using System;

namespace CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____ Compound Interest Calculator");

            decimal principal = 1000m;
            int year = 10;
            double rate = 0.05;

            for (int i = 1; i <= year; i++)
            {
                decimal compoundInterest =principal *  (decimal)(Math.Pow(( 1.0 + rate), i));
                Console.Write($"Compound interest for year {i, 4} is {compoundInterest:C}\n");
            }
        }
    }
}
