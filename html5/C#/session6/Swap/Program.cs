using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num1 = 2;
            int num2 = 3;
        
            
            Swap( ref num1, ref num2);
              Console.WriteLine($"The value of num1 is {num1} num2 is {num2}");
        }

        
        private static void Swap(ref int a, ref int b){
             int c = a;
            a = b;
            b = c;
           
        }
    }

}
