using System;

namespace Abstract
{
    class Program
    {
        public static void Main()
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 245,
                FirstName = "John",
                LastName = "Joseph",
                AnnualSalary = 80000
            };
        
            Console.WriteLine($"Name: {fte.GetFullName()}");
            Console.WriteLine($"Salary: {fte.GetMonthlySalary():C} ");

            Console.WriteLine("__________");


             ContractEmployee cte = new ContractEmployee()
            {
                ID = 355,
                FirstName = "May",
                LastName = "Balogun",
                HourlyPay = 200,
                TotalHours = 60
            };
        
            Console.WriteLine($"Name: {cte.GetFullName()} ");
            Console.WriteLine($"Salary: {cte.GetMonthlySalary():C} ");

        }
    }
}
