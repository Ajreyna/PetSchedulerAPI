using System;
using System.Collections.Generic;
using System.Linq;
using PetSchedulerAPI.Core.Models;
using PetSchedulerAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace PetSchedulerAPI.Infrastructure.Data
{
    public class JobDetailsRepository : IJobDetailsRepository
    {
        private readonly AppDbContext _dbContext;

        public JobDetailsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public JobDetails Add(JobDetails todo)
        {
            _dbContext.Activities.Add(todo);
            _dbContext.SaveChanges();
            return todo;
        }

        public JobDetails Get(int id)
        {
            return _dbContext.Activities
                .Include(a => a.JobType)
                .Include(a => a.User)
                .SingleOrDefault(b => b.Id == id);
        }

        public IEnumerable<JobDetails> GetAll()
        {
            return _dbContext.Activities
                .Include(a => a.JobType)
                .Include(a => a.User)
                .ToList();
        }

        public void Remove(JobDetails todo)
        {
            _dbContext.Activities.Remove(todo);
            _dbContext.SaveChanges();
        }

        public JobDetails Update(JobDetails updatedJobDetails)
        {
            var currentJobDetails = _dbContext.Activities.Find(updatedJobDetails.Id);

            if (currentJobDetails == null) return null;

            _dbContext.Entry(currentJobDetails)
                .CurrentValues
                .SetValues(updatedJobDetails);

            _dbContext.Activities.Update(currentJobDetails);
            _dbContext.SaveChanges();
            return currentJobDetails;
        }

        public IEnumerable<JobDetails> GetAllForUser(int userId)
        {
            return _dbContext.Activities
                .Include(a => a.JobType)
                .Include(a => a.User)
                .Where(a => a.UserId == userId)
                .ToList();
        }
    }
}
