using System;

class comparison
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int number1 = int.Parse(Console.ReadLine());

         Console.Write("Enter an operator: ");
        string operato = Console.ReadLine();
        
            Console.Write("Enter second integer: ");
            int number2 = int.Parse(Console.ReadLine());

            if (operato == "*")
            {
                int mult = number1 * number2;
                Console.WriteLine($"{mult}");
            };
            if (operato == "/")
            {
                int div = number1 / number2;
                Console.WriteLine($"{div}");
            };
            if (operato == "+")
            {
                int sum = number1 + number2;
                Console.WriteLine($"{sum}");
            };
             if (operato == "-")
            {
                int minus = number1 + number2;
                Console.WriteLine($"{minus}");
            };
             if (operato == "%")
            {
                int modulo = number1 % number2;
                Console.WriteLine($"{modulo}");
            };
         

        }
    }

