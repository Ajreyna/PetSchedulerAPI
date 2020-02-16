using System;
using System.Collections.Generic;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class ActivityTypeService : IActivityTypeService
    {
        private IActivityTypeRepository _activityTypeRepo;

        // inject an IActivityTypeRepository in the constructor
        public ActivityTypeService(IActivityTypeRepository ActivityTypeRepo)
        {
            _activityTypeRepo = ActivityTypeRepo;
        }

        public ActivityType Add(ActivityType ActivityType)
        {
            // add new activity type
            _activityTypeRepo.Add(ActivityType);
            return ActivityType;
        }

        public ActivityType Get(int id)
        {
            // get activity type by id
            return _activityTypeRepo.Get(id);
        }

        public ActivityType Update(ActivityType updatedActivityType)
        {
            // update activity type
            var ActivityType = _activityTypeRepo.Update(updatedActivityType);
            return ActivityType;
        }

        public void Remove(ActivityType ActivityType)
        {
            // delete activity type
            _activityTypeRepo.Remove(ActivityType);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            // get all activity types
            return _activityTypeRepo.GetAll();
        }
    }
}
