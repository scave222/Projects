using System;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Num1: ");
            double Num1 =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter Num2: ");
            double Num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter Num3: ");
            double Num3 = Convert.ToDouble(Console.ReadLine());
            double maximum = MaximumFunction(Num1, Num2, Num3);
            Console.WriteLine($"Largest is {maximum}");

            static double MaximumFunction(double Num1, double Num2, double Num3){
            
                double largest = Num1;
                if (Num2 > largest){
                    largest = Num2;
                }
                if (Num3 > largest){
                    largest = Num3;
                }
                return largest;
                
            }
            
        }
    }
}
