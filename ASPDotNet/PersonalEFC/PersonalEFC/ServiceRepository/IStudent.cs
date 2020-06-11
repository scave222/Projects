using PersonalEFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalEFC.ServiceRepository
{
    public interface IStudent
    {
        IEnumerable<Student> Students { get; }
        public void AddStudent(Student student);
    }
}
