using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            char operato;
            double first, second, result;
             
            Console.Write("Enter first number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (1, 2, 3, 4, 5, 6, which represent +,-,*, /): ");
            operato = (char)Console.Read();
            switch(operato)
            {
                case '1':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;
                 
                case '2':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;
                 
                case '3':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;
                 
                case '4':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;

                case '5':
                    result = first++ + second++;
                    Console.WriteLine("{0}++ + {1}++ = {2}", first, second, result);
                    break;

                case '6':
                    result = first-- - second--;
                    Console.WriteLine("{0}-- - {1}-- = {2}", first, second, result);
                    break;
 
                default:
                    Console.WriteLine("Invalid Operator");
                    break;

            }
                     
        
        }
    }
}
