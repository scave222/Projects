using System;

namespace GenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> addNum1Delegate = Add1Num;
            double result = addNum1Delegate(5, 3.5f, 5.0);
            Console.WriteLine($"Working with the Func Delegate\nResult is = {result}");

            Action<int, float, double> add2NumDelegate = Add2Num;
            add2NumDelegate(5, 3.5f, 5.0);

             Action<int, float, double> addNumDel = delegate(int num1, float num2, double num3){        //Anonymouse delegate
                 Console.WriteLine($"Working with the action delegate with anonymouse method\nResult is {num1 + num2 + num3}");

             };
             addNumDel(5, 3.5f, 5.0);

            Predicate<string> check = CheckLength;
            bool letter = check("Caleb");
            Console.WriteLine($"The length of the name in the predicate is greater than 5: {letter}");

            
        }

        static double Add1Num(int num1, float num2, double num3)
        {
            return num1 + num2 + num3;
        }

        static void Add2Num(int num1, float num2, double num3)
        {
            Console.WriteLine($"Working with the action delegate\nResult is {num1 + num2 + num3}");
        }

        static bool CheckLength(string name){
                if(name.Length > 5)
                {
                    return true;
                }
                return false;
            }
    }
}
