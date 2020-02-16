using System;
using System.Collections.Generic;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public interface IActivityTypeRepository
    {
        // Create
        ActivityType Add(ActivityType todo);
        // Read
        ActivityType Get(int id);
        // Update
        ActivityType Update(ActivityType todo);
        // Delete
        void Remove(ActivityType todo);
        // List
        IEnumerable<ActivityType> GetAll();
    }
}
