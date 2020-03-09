using System.Collections.Generic;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.Core.Services
{
    public interface IJobTypeService
    {
        JobType Add(JobType JobType);
        JobType Get(int id);
        IEnumerable<JobType> GetAll();
        void Remove(JobType JobType);
        JobType Update(JobType updatedJobType);
    }
}