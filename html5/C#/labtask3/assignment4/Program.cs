using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an integer: ");
            int second = Convert.ToInt32(Console.ReadLine());

            bool multiple = method(first, second);
            Console.WriteLine(multiple);

           static bool method(int num1, int num2){
                if(num1 % num2 == 0)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
    }
}
