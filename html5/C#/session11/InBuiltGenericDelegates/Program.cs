using System;

namespace InBuiltGenericDelegates
{
    public delegate double Add1Delegate(int a, float b, double c);
    public delegate void Add2Delegate(int a, float b, double c);
    public delegate bool CheckDelegate(string a);
    class Program
    {
        static void Main(string[] args)
        {
            Add1Delegate add1Num = Add1;
            Add2Delegate add2Num = Add2;
            CheckDelegate checkLength = CheckLength;

            double result = add1Num(5, 3.5f, 6.0);
            Console.WriteLine($"Delegate 1: The sum of the three numbers is {result}");

            add2Num(5, 3.5f, 6.0);

            bool status = checkLength("James Stuart");
            Console.WriteLine($"The length of the name is greater than 5: {status}");
        
         }
            private static double Add1(int num1, float num2, double num3)
            {
                return num1 + num2 + num3;
            }

            private static void Add2(int num1, float num2, double num3)
            {
                Console.WriteLine($"The sum of numbers is {num1+num2+num3}");
            }

            private static bool CheckLength(string name){
                if(name.Length > 5)
                {
                    return true;
                }
                return false;
            }
       
    }
}
