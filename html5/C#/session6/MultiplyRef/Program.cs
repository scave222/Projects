using System;

namespace MultiplyRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            double num2 = 3;

            
            Multiply(ref num1, ref num2);

             Console.WriteLine($"The value of ref is {num1} and {num2}");
            Console.WriteLine("Hello World!");
             
           
        }
         private static void Multiply(ref int a, ref double b){
                a = a * 2;   
                b = b * 4;
            }
    }
}
