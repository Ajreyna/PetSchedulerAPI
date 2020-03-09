using System;
using System.Collections.Generic;
using System.Linq;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.ApiModels
{
    public static class JobDetailslsMappingExtensions
    {

        public static JobDetailsModel ToApiModel(this JobDetails jobDetails)
        {
            return new JobDetailsModel
            {
                Id = jobDetails.Id,
                Date = jobDetails.Date,
                JobDetailsTypeId = jobDetails.JobTypeId,
                JobDetailsType = jobDetails.JobType.Name,
                Duration = jobDetails.Duration,
                Distance = jobDetails.Distance,
                UserId = jobDetails.UserId,
                User = jobDetails.User.Name,
                Notes = jobDetails.Notes,
            };
        }

        public static JobDetails ToDomainModel(this JobDetailsModel JobDetailsModel)
        {
            return new JobDetails
            {
                Id = JobDetailsModel.Id,
                Date = JobDetailsModel.Date,
                JobTypeId = JobDetailsModel.JobDetailsTypeId,
                JobType = null,
                Duration = JobDetailsModel.Duration,
                Distance = JobDetailsModel.Distance,
                UserId = JobDetailsModel.UserId,
                User = null,
                Notes = JobDetailsModel.Notes,
            };
        }

        public static IEnumerable<JobDetailsModel> ToApiModels(this IEnumerable<JobDetails> jobDetails2)
        {
            return jobDetails2.Select(a => a.ToApiModel());
        }

        public static IEnumerable<JobDetails> ToDomainModels(this IEnumerable<JobDetailsModel> JobDetailsModels)
        {
            return JobDetailsModels.Select(a => a.ToDomainModel());
        }
    }
}
