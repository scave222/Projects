using System;
using System.Collections;
using System.Collections.Generic;

namespace Icomparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>(){50, 40, 30,10,5};
            Console.WriteLine("Items in list before sorting...");
            foreach(var num in nums)
            {
                Console.WriteLine($"{num}");
            }

            nums.Sort();
             Console.WriteLine("Items in list before sorting...");
             foreach (var num in nums)
             {
                 Console.WriteLine($"{num}");
             }

             List<Employee> employees = new List<Employee>{new Employee(101,"james Stuart", "Sales"),
                                                          new Employee(102,"David Joshua", "IT"),
                                                          new Employee(103,"Anthony Web", "Account"),
                                                          new Employee(100,"Ifeanyi Rutherford", "Maintenance"),
                                                          new Employee(99,"Caleb Rose", "Marketting")};

             Console.WriteLine("Items in list before sorting...");
             foreach (Employee employee in employees)
             {
                 Console.WriteLine($"{employee.ToString()}");
             }

            employees.Sort();
            employees.Reverse();
            Console.WriteLine("Items in list after sorting...");
             foreach (Employee employee in employees)
             {
                 Console.WriteLine($"{employee.ToString()}");
             }

             
        }
    }
}
