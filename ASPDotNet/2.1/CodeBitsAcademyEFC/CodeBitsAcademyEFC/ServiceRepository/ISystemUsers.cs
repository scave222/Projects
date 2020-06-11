using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeBitsAcademyEFC.Models;

namespace CodeBitsAcademyEFC.ServiceRepository
{
    public interface ISystemUsers
    {
        IEnumerable<SystemUsers> SystemUsers { get; }
        //object Departments { get; }

        public void AddUsers(SystemUsers users);

        SystemUsers Delete(long Id);
        SystemUsers GetUsers(long Id);
        void EditUsers(SystemUsers users);

        IQueryable<SystemUsers> Search(string Name, long id);
        public bool Login(string username, string password);
    }
}
