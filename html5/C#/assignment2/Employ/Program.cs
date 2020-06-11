using System;

namespace Employ
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write($"Enter your first name : ");
            string firstName = Console.ReadLine();

            Console.Write($"Enter your last name : ");
            string lastName = Console.ReadLine();
            
            Console.Write($"Enter your salary : ");
            int salary =Convert.ToInt32(Console.ReadLine());

            Employee employee1 = new Employee (firstName, lastName, salary);

            Console.Write($"Enter your first name : ");
            string firstName2 = Console.ReadLine();

            Console.Write($"Enter your last name : ");
            string lastName2 = Console.ReadLine();
            
            Console.Write($"Enter your salary : ");
            int salary2 =Convert.ToInt32(Console.ReadLine());

            Employee employee2 = new Employee (firstName2, lastName2, salary2);
             

             Console.WriteLine ($"First Name:  {employee1.FirstName}\nLast name: {employee1.LastName}\nSalary: {employee1.salaries:C}");
            
            Console.WriteLine();

           employee1.salaries = employee1.salaries * (decimal)1.1;
           Console.WriteLine($"New salary is {employee1.salaries:C}");

            Console.WriteLine ($"First Name:  {employee2.FirstName}\nLast name: {employee2.LastName}\nSalary: {employee2.salaries:C}");
            
           employee2.salaries = employee2.salaries * (decimal)1.1;
           Console.WriteLine($"New salary is {employee2.salaries:C}");
        }
    }
}
