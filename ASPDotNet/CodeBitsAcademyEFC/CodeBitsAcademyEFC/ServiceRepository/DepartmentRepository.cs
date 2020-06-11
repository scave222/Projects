using CodeBitsAcademyEFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeBitsAcademyEFC.ServiceRepository
{
    public class DepartmentRepository : IDepartment
    {
        private readonly DataContext context;
        public DepartmentRepository(DataContext cxt)
        {
            context = cxt;
        }

        public IEnumerable<Department> Departments => context.DepartmentTable;

        public void AddDept(Department dept)
        {
            context.DepartmentTable.Add(dept);
            context.SaveChanges();
        }

        public Department Dept(string department)
        {
            var dep = context.DepartmentTable.Find(department);
            return dep;
        }
        
    }
}
