using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of side side1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

             Console.Write("Enter the length of side side2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            double result = Hypotenuse(side1,side2);
            Console.Write($"The Hypotenuse is: {result}");


            static double Hypotenuse(double a, double b){
                double mult = (a*a) + (b*b);
                return Math.Sqrt(mult);
            } 

        }
    }
}
