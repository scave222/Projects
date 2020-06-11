using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitsAcademyEFC.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }
        public DbSet<Employee> EmployeesTable { get; set; }
        public DbSet<SystemUsers> SystemUsersTable { get; set; }
        public DbSet<Department> DepartmentTable { get; set; }
    }
}
