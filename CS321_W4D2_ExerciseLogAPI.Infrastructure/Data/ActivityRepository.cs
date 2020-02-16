using System;
using System.Collections.Generic;
using System.Linq;
using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly AppDbContext _dbContext;

        public ActivityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Activity Add(Activity todo)
        {
            _dbContext.Activities.Add(todo);
            _dbContext.SaveChanges();
            return todo;
        }

        public Activity Get(int id)
        {
            return _dbContext.Activities
                .Include(a => a.ActivityType)
                .Include(a => a.User)
                .SingleOrDefault(b => b.Id == id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return _dbContext.Activities
                .Include(a => a.ActivityType)
                .Include(a => a.User)
                .ToList();
        }

        public void Remove(Activity todo)
        {
            _dbContext.Activities.Remove(todo);
            _dbContext.SaveChanges();
        }

        public Activity Update(Activity updatedActivity)
        {
            var currentActivity = _dbContext.Activities.Find(updatedActivity.Id);

            if (currentActivity == null) return null;

            _dbContext.Entry(currentActivity)
                .CurrentValues
                .SetValues(updatedActivity);

            _dbContext.Activities.Update(currentActivity);
            _dbContext.SaveChanges();
            return currentActivity;
        }

        public IEnumerable<Activity> GetAllForUser(int userId)
        {
            return _dbContext.Activities
                .Include(a => a.ActivityType)
                .Include(a => a.User)
                .Where(a => a.UserId == userId)
                .ToList();
        }
    }
}
