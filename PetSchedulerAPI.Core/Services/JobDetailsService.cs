using System;
using System.Collections.Generic;
using PetSchedulerAPI.Core.Models;
using PetSchedulerAPI.Core.Services;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    public class JobDetailsService : IJobDetailsService
    {
        private IJobDetailsRepository _JobDetailsRepo;
        private IJobTypeRepository _JobTypeRepo;

        public JobDetailsService(IJobDetailsRepository JobDetailsRepo, IJobTypeRepository JobTypeRepo)
        {
            _JobDetailsRepo = JobDetailsRepo;
            _JobTypeRepo = JobTypeRepo;
        }

        public JobDetails Add(JobDetails JobDetails)
        {
            // retrieve the JobType so we can check
            var JobType = _JobTypeRepo.Get(JobDetails.JobTypeId);

            // for a DurationAndDistance JobDetails, you must supply a Distance
            if (JobType.RecordType == RecordType.DurationAndDistance
                && JobDetails.Distance <= 0)
            {
                throw new ApplicationException("You must supply a Distance for this JobDetails.");
            }
            if (JobDetails.Duration <= 0)
            {
                throw new ApplicationException("You must supply a duration for this JobDetails.");
            }
            _JobDetailsRepo.Add(JobDetails);
            return JobDetails;
        }

        public JobDetails Get(int id)
        {
            // return specified JobDetails by id with Find()
            return _JobDetailsRepo.Get(id);
        }

        public IEnumerable<JobDetails> GetAll()
        {
            // return all activities using ToList()
            return _JobDetailsRepo.GetAll();
        }

        public JobDetails Update(JobDetails updatedJobDetails)
        {
            // update the JobDetails and save
            var JobDetails = _JobDetailsRepo.Update(updatedJobDetails);
            return JobDetails;
        }

        public void Remove(JobDetails JobDetails)
        {
            // delete the JobDetails
            _JobDetailsRepo.Remove(JobDetails);
        }
    }
}
