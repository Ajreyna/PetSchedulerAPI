using System;
using System.Collections.Generic;
using System.Linq;
using PetSchedulerAPI.Core.Models;
using PetSchedulerAPI.Core.Services;

namespace PetSchedulerAPI.Infrastructure.Data
{
    public class JobTypeRepository : IJobTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public JobTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public JobType Add(JobType todo)
        {
            _dbContext.JobTypes.Add(todo);
            _dbContext.SaveChanges();
            return todo;
        }

        public JobType Get(int id)
        {
            return _dbContext.JobTypes
                .SingleOrDefault(b => b.Id == id);
        }

        public IEnumerable<JobType> GetAll()
        {
            return _dbContext.JobTypes.ToList();
        }

        public void Remove(JobType todo)
        {
            _dbContext.JobTypes.Remove(todo);
            _dbContext.SaveChanges();
        }

        public JobType Update(JobType updatedJobType)
        {
            var currentJobType = _dbContext.JobTypes.Find(updatedJobType);

            if (currentJobType == null) return null;

            _dbContext.Entry(currentJobType)
                .CurrentValues
                .SetValues(updatedJobType);

            _dbContext.JobTypes.Update(currentJobType);
            _dbContext.SaveChanges();
            return currentJobType;
        }
    }
}
