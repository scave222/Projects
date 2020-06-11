using System;

namespace PassingArrayToFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];

            int sum = 0;

             int[] Sum(int[] numbers)
            {
                 

            for (int i = 0; i <= 49; i++)
            {

                numbers[i] = i + 1 ;
                sum += numbers[i];          
            }
            return numbers;
           
            }
             Sum(arr);
              Console.Write($"{sum}");
            

           
            
        }
    }
}
