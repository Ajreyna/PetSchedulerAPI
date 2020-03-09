using System.Collections.Generic;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.Core.Services
{
    public interface IJobDetailsService
    {
        JobDetails Add(JobDetails JobDetails);
        JobDetails Get(int id);
        IEnumerable<JobDetails> GetAll();
        void Remove(JobDetails JobDetails);
        JobDetails Update(JobDetails updatedJobDetails);
    }
}