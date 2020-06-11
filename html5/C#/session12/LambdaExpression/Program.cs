using System;

namespace LambdaExpression
{
    //public delegate int CalculateValue(string a); 
    class Program
    {
        static void Main(string[] args)
        {
            // CalculateValue CalDelegate = Calculate;
            // int result = CalDelegate("Hi");
            // Console.Write(result);


            // Func<string,int> CalculateValue = delegate(string x)
            //     {
            //         return 5;
            //     };

            //     Console.Write(CalculateValue("hi"));


             Func<string,int> CalculateValue = Calculate;
            int result = CalculateValue("Hi");

            Console.Write(result);
        }
           

        static public int Calculate(string x)
        {
            return 5;
        }
    }
}
