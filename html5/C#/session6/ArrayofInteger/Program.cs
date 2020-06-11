using System;

namespace ArrayofInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[50];

            int sum = 0;

            for (int i = 0; i <= 49; i++)
            {

                numbers[i] = i + 1 ;
                sum += numbers[i];          
            }
            Console.WriteLine($"{sum}");
             
             
        }
    }
}
