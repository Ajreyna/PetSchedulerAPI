using System;
using System.Collections.Generic;
using System.Linq;
using CS321_W4D2_ExerciseLogAPI.Core.Models;
using CS321_W4D2_ExerciseLogAPI.Core.Services;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class ActivityTypeRepository : IActivityTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public ActivityTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActivityType Add(ActivityType todo)
        {
            _dbContext.ActivityTypes.Add(todo);
            _dbContext.SaveChanges();
            return todo;
        }

        public ActivityType Get(int id)
        {
            return _dbContext.ActivityTypes
                .SingleOrDefault(b => b.Id == id);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _dbContext.ActivityTypes.ToList();
        }

        public void Remove(ActivityType todo)
        {
            _dbContext.ActivityTypes.Remove(todo);
            _dbContext.SaveChanges();
        }

        public ActivityType Update(ActivityType updatedActivityType)
        {
            var currentActivityType = _dbContext.ActivityTypes.Find(updatedActivityType);

            if (currentActivityType == null) return null;

            _dbContext.Entry(currentActivityType)
                .CurrentValues
                .SetValues(updatedActivityType);

            _dbContext.ActivityTypes.Update(currentActivityType);
            _dbContext.SaveChanges();
            return currentActivityType;
        }
    }
}
