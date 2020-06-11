using System;

namespace ProductSeries
{
    class Program
    {
        static void Main(string[] args)
         {
            Console.WriteLine($"Product called with 1 argument supplied: {product(12)}");
            Console.WriteLine($"Product called with 2 argument supplied: {product(3,8)}");
            Console.WriteLine($"Product called with 3 argument supplied: {product(6,7,4)}");
        }

        static int product(params int[] num)
        {
            int mult = 1;
            for(int i = 0; i < num.Length; i++)
            {
                int squared = num[i];
                mult = mult * squared;
            }
            return mult;
        }
    }
}
