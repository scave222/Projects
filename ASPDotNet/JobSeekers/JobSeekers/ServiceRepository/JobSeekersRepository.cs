using JobSeekers.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSeekers.ServiceRepository
{
    public class JobSeekersRepository : IJobSeeker
    {
        private readonly DataContext context;
        public JobSeekersRepository(DataContext cxt)
        {
            context = cxt;
        }
       public IEnumerable<JobSeeker> Jobseek
        {
            get
            {
                return context.JobSeekersTable;
            }
        }

        public void AddJobSeeker(JobSeeker jobseeker)
        {
            context.JobSeekersTable.Add(jobseeker);
            context.SaveChanges();
        }
        public JobSeeker Delete(long Id)
        {
            JobSeeker seeker = context.JobSeekersTable.Find(Id);
            if (seeker != null)
            {
                context.JobSeekersTable.Remove(seeker);
                context.SaveChanges();
            }
            return seeker;
        }
        public JobSeeker GetJobSeeker(long Id)
        {
            return context.JobSeekersTable.Find(Id);
        }
        public void EditJobSeeker(JobSeeker jobseeker)
        {
            context.Entry(jobseeker).State = EntityState.Modified;
            context.SaveChanges();
        }
        public IQueryable<JobSeeker> Search(string FName)
        {
           var seek = context.JobSeekersTable.Where(j => j.FirstName.Contains(FName)
            || j.LastName.Contains(FName)
            || j.Qualification.Contains(FName)
            || j.CourseOfStudy.Contains(FName));
            if(seek != null)
            {
                return seek;
            }
            throw new ArgumentOutOfRangeException("Job seeker not found");

        }
    }
}
