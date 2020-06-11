using CodeBitsAcademyEFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitsAcademyEFC.ServiceRepository
{
    public interface IDepartment
    {
        public IEnumerable<Department> Departments { get; }
        //object DepartmentName { get; }

        public Department Dept(string department);
        public void AddDept(Department dept);
    }
}
