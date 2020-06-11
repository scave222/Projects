using System;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator= new Calculator();
            calculator.Num1 = 45;
            calculator.Num2 = 34;

            Console.Write($"Call add method returns: {calculator.add()}\n");
            Console.Write($"Call sub method returns: {calculator.sub()}\n");
            Console.Write($"Call mult method returns: {calculator.mult()}\n");
            Console.Write($"Call divide method returns: {calculator.divide()}\n");
        }
    }
}
