using System;
namespace MultiCastDeligate
{
    public class Aritmethic
    {
         static public void Add(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
        }

        static public void Subtract(int num1, int num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1-num2}");
        }

        static public void Multiplication(int num1, int num2)
        {
            Console.WriteLine($"{num1} * {num2} = {num1*num2}");
        }

        static public void Division(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine($"{num1} / {num2} cannot be divided by Zero");
            }
            Console.WriteLine($"{num1} / {num2} = {num1/num2}");
        }
    }
}