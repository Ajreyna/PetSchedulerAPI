using System;
using System.Collections.Generic;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.Core.Services
{
    public interface IJobDetailsRepository
    {
        // Create
        JobDetails Add(JobDetails todo);
        // Read
        JobDetails Get(int id);
        // Update
        JobDetails Update(JobDetails todo);
        // Delete
        void Remove(JobDetails todo);
        // List
        IEnumerable<JobDetails> GetAll();
    }
}
