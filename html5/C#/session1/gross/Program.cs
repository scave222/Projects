using System;

namespace grossPay
{
    class Program
    {
        static void Main()
        {
            int count =1;
            while (count <= 3)
             {
                 count++;
            Console.Write("Enter hourly rate: ");
            double hourlyRate = double.Parse(Console.ReadLine());

            Console.Write("Enter hours worked: ");
            double hoursWorked = double.Parse(Console.ReadLine());

             if (hoursWorked < 0 ){
                Console.WriteLine($"Wrong input");
            }

            else if (hoursWorked >= 0 && hoursWorked <= 40)
            {
                double pay = hourlyRate * hoursWorked;
                Console.WriteLine("Pay for employee is  {0:C2}", pay);
            }

            else if (hoursWorked > 40)
            {
                double pay = hourlyRate * 40;
                double extraHours = hoursWorked - 40;
                double extraPay = extraHours * 1.5 * hourlyRate;
                double payment = pay + extraPay;
                Console.WriteLine("Pay for employee is  {0:C2}", payment);
            }

           
        };
            
        }
    }
}
