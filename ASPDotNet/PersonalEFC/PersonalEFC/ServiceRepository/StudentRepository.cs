using PersonalEFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalEFC.ServiceRepository
{
    public class StudentRepository : IStudent
    {
        private readonly DataContext context;
        public StudentRepository(DataContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Student> Students
        {
            get
            {
                return context.StudentsTable;
            }
        }

        public void AddStudent(Student student)
        {
            context.StudentsTable.Add(student);
            context.SaveChanges();
        }
    }
}
