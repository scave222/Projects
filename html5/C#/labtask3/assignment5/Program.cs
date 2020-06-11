using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 4.432f;
            float num2 = 4.3f;
            float num3 = 4.235f;

            float result = Minimum3(num1,num2,num3);
            Console.Write($"The minimum is: {result}");

            static float Minimum3(float num1, float num2, float num3)
            {
                return Math.Min(num1, Math.Min(num2, num3));
            }
        }
    }
}
