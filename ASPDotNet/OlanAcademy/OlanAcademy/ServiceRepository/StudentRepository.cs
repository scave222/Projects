using OlanAcademy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OlanAcademy.ServiceRepository
{
    public class StudentRepository : IStudent
    {
        private readonly DataContext context;
        //public EmployeeRepository(DataContext ctx) => context =ctx;
        public StudentRepository(DataContext ctx)
        {
            context = ctx;
        }
        //Implement IStudent interface
        //List Student Method
        //public IEnumerable<Student> Students => context.StudentssTable;
        public IEnumerable<Student> Students
        {
            get
            {
                return context.StudentsTable;
            }
        }

        //Add Employee Methods
        public void AddStudent(Student student)
        {
            context.StudentsTable.Add(student);
            context.SaveChanges();
        }

        public Student Delete(long Id)
        {
            Student student = context.StudentsTable.Find(Id);
            if (student != null)
            {
                context.StudentsTable.Remove(student);
                //After remove the employee then save changes to database
                context.SaveChanges();
            }

            return student;

        }
        public Student GetStudent(long Id)
        {
            return context.StudentsTable.Find(Id);
        }

        public void EditStudent(Student student)
        {
            //context.EmployeesTable.Update(employee);
            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
