using CodeBitsAcademyEFC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitsAcademyEFC.ServiceRepository
{
    public class SystemUsersRepository : ISystemUsers
    {
        private readonly DataContext context;
        public SystemUsersRepository(DataContext cxt)
        {
            context = cxt;
        }
        public IEnumerable<SystemUsers> SystemUsers
        {
            get
            {
                return context.SystemUsersTable;
            }
        }

        //public object ModelState { get; private set; }

        //public object Departments => throw new NotImplementedException();

        public void AddUsers(SystemUsers users)
        {
            context.SystemUsersTable.Add(users);
            context.SaveChanges();
        }

        public SystemUsers Delete(long Id)
        {
            SystemUsers user = context.SystemUsersTable.Find(Id);
            if(user != null)
            {
                context.SystemUsersTable.Remove(user);
                context.SaveChanges();
            }
            return user;
        }
        public SystemUsers GetUsers(long Id)
        {
            return context.SystemUsersTable.Find(Id);
        }
        public void EditUsers(SystemUsers users)
        {
            context.Entry(users).State = EntityState.Modified;
            context.SaveChanges();
        }

        public IQueryable<SystemUsers> Search(string Name, long id)
        {
            var user = context.SystemUsersTable.Where(s => s.Username.Contains(Name) || s.Id == id || s.Role.Contains(Name) || s.Status.Contains(Name));
            return user;
        }

        public bool Login(string username, string password)
        {
            var log = context.SystemUsersTable.Where(l => l.Username == username && l.Password == password);
            if (log.Count() > 0)
            {
                return true;
            }
            else return false;

        }
    }
}
