using System;

namespace Task4
{
    class Program
    {
        static void Main()
        {

    int[] numbers = {9, 3, 6, 8, 1};
    int min = numbers[0];

    for (int i = 0; i < numbers.Length; i++) {
        int number = numbers[i];

        if (number < min) {
            min = number;
        }
    }

    Console.Write($" The minimum is : {min}");
     
   
        }
    }
}
