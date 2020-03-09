using System;
using System.Collections.Generic;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.Core.Services
{
    public class JobTypeService : IJobTypeService
    {
        private IJobTypeRepository _JobTypeRepo;

        // inject an IJobTypeRepository in the constructor
        public JobTypeService(IJobTypeRepository JobTypeRepo)
        {
            _JobTypeRepo = JobTypeRepo;
        }

        public JobType Add(JobType JobType)
        {
            // add new activity type
            _JobTypeRepo.Add(JobType);
            return JobType;
        }

        public JobType Get(int id)
        {
            // get activity type by id
            return _JobTypeRepo.Get(id);
        }

        public JobType Update(JobType updatedJobType)
        {
            // update activity type
            var JobType = _JobTypeRepo.Update(updatedJobType);
            return JobType;
        }

        public void Remove(JobType JobType)
        {
            // delete activity type
            _JobTypeRepo.Remove(JobType);
        }

        public IEnumerable<JobType> GetAll()
        {
            // get all activity types
            return _JobTypeRepo.GetAll();
        }
    }
}
