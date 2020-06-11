using CodeBitsAcademyEFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitsAcademyEFC.ServiceRepository
{
    public interface IEmployee
    {
        IEnumerable<Employee> Employees { get; }
        public void AddEmployee(Employee employee);

        Employee Delete(long Id);
        Employee GetEmployee(long Id);
        void EditEmployee(Employee employee);

        IQueryable <Employee> Search(string FName);
        
    }

    
}
