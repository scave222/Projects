using CodeBitsAcademyEFC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitsAcademyEFC.ServiceRepository
{
    public class EmployeeRepository : IEmployee
    {
        
        private readonly DataContext context;
        //public EmployeeRepository(DataContext ctx) => context =ctx;
        public EmployeeRepository(DataContext ctx)
        {
            context = ctx;           
        }
        //Implement IEmployee interface
        //List Employee Method
        //public IEnumerable<Employee> Employees => context.EmployeesTable;
        public IEnumerable<Employee>Employees
        {
            get 
            { 
                return context.EmployeesTable; 
            }
        }

        //Add Employee Methods
        public void AddEmployee(Employee employee)
        {

            context.EmployeesTable.Add(employee);
            context.SaveChanges();
        }

        public Employee Delete(long Id)
        {
            Employee employee = context.EmployeesTable.Find(Id);
            if (employee != null)
            {
                context.EmployeesTable.Remove(employee);
                //After remove the employee then save changes to database
                context.SaveChanges();
            }
            
                return employee;
            
        }
        public Employee GetEmployee(long Id)
        {
            return context.EmployeesTable.Find(Id);
        }

        public void EditEmployee(Employee employee)
        {
                //context.EmployeesTable.Update(employee);
                context.Entry(employee).State = EntityState.Modified;
                context.SaveChanges();
            
        }

        public IQueryable<Employee> Search(string FName)
        {
            //return context.EmployeesTable.Where(C => C.FirstName == FName).OrderBy(C => C.FirstName);
           // return context.EmployeesTable.Where(c => c.FirstName == FName);
             var employee = context.EmployeesTable.Where(s => s.FirstName.Contains(FName) || s.LastName.Contains(FName) || s.PhoneNumber.Contains(FName));
            return employee;

        }

    }
}
