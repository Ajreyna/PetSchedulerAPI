using System;
using System.Collections.Generic;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.Core.Services
{
    public interface IJobTypeRepository
    {
        // Create
        JobType Add(JobType todo);
        // Read
        JobType Get(int id);
        // Update
        JobType Update(JobType todo);
        // Delete
        void Remove(JobType todo);
        // List
        IEnumerable<JobType> GetAll();
    }
}
