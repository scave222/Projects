using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSeekers.Models;

namespace JobSeekers.ServiceRepository
{
    public interface IJobSeeker
    {
        IEnumerable<JobSeeker> Jobseek { get; }
        public void AddJobSeeker(JobSeeker jobseeker);

        JobSeeker Delete(long Id);
        JobSeeker GetJobSeeker(long Id);
        void EditJobSeeker(JobSeeker jobseeker);

        IQueryable<JobSeeker> Search(string FName);
    }
}
