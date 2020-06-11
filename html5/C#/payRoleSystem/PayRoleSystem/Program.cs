using System;
using System.Collections.Generic;

namespace PayRoleSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee salariedEmployee = new SalariedEmployee("James", "Stuart", 001, 10000m);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Ruth", "Rutherford", 241, 40, 500m);
            CommisionedEmployee commissionedEmployee = new CommisionedEmployee("John", "Stuart", 201, 0.08, 10000m);
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("John", "Ruth", 001, 10.04m, 0.06, 2000m);

            // Console.WriteLine(salariedEmployee);
            // Console.WriteLine($"Earnings: {salariedEmployee.Earnings():C}\n");

            // Console.WriteLine(hourlyEmployee);
            // Console.WriteLine($"Earnings: {hourlyEmployee.Earnings():C}\n");

            // Console.WriteLine(commissionedEmployee);
            // Console.WriteLine($"Earnings: {commissionedEmployee.Earnings():C}\n");

            // Console.WriteLine(basePlusCommissionEmployee);
            // Console.WriteLine($"Earnings: {basePlusCommissionEmployee.Earnings():C}\n");

            Console.WriteLine("=== POLYMORPHYCALLY ACCESSING METHODS OF OBJECTS CREATED FROM CONCRETE DERIVED-CLASSES OF AN ABSTRACT BASE CLASS");
            List<Employee> employees = new List<Employee> () {salariedEmployee, hourlyEmployee, commissionedEmployee, basePlusCommissionEmployee};
            // Employee[] employee = new Employee[4] {salariedEmployee, hourlyEmployee, commissionedEmployee, basePlusCommissionEmployee};

            foreach (Employee employee in employees){
                 Console.WriteLine(employee);
                Console.WriteLine($"Earnings: {employee.Earnings():C}\n");
                
                if (employee is BasePlusCommissionEmployee)
                {
                    var baseEmply = (BasePlusCommissionEmployee)employee;
                    baseEmply.BaseSalary *= 1.10m;
                    Console.WriteLine($"Salary increment by: 10% {baseEmply.BaseSalary}");
                }

               
            }
        }
    }
}
