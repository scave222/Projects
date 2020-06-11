using System;

namespace grossPay
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter hourly rate: ");
            double hourlyRate = double.Parse(Console.ReadLine());

            Console.Write("Enter hours worked: ");
            double hoursWorked = double.Parse(Console.ReadLine());

            if (hoursWorked <= 40)
            {
                double pay = hourlyRate * hoursWorked;
                Console.WriteLine($"Pay for employee is ${pay}");
            }

            else if (hoursWorked > 40)
            {
                double pay = hourlyRate * 40;
                double extraHours = hoursWorked - 40;
                double extraPay = extraHours * 1.5 * hourlyRate;
                double payment = pay + extraPay;
                Console.WriteLine($"Pay for employee is ${payment}");
            }

            else {
                Console.WriteLine($"Wrong input");
            }
        }
    }
}
