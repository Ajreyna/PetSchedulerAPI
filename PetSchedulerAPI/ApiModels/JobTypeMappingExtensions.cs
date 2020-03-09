using System;
using System.Collections.Generic;
using System.Linq;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.ApiModels
{
    public static class JobTypeMappingExtenstions
    {

        public static JobTypeModel ToApiModel(this JobType JobType)
        {
            return new JobTypeModel
            {
                Id = JobType.Id,
                // fill in property mappings
                Name = JobType.Name,
                RecordType = JobType.RecordType,
            };
        }

        public static JobType ToDomainModel(this JobTypeModel JobTypeModel)
        {
            return new JobType
            {
                Id = JobTypeModel.Id,
                // fill in property mappings
                Name = JobTypeModel.Name,
                RecordType = JobTypeModel.RecordType,
            };
        }

        public static IEnumerable<JobTypeModel> ToApiModels(this IEnumerable<JobType> JobTypes)
        {
            return JobTypes.Select(a => a.ToApiModel());
        }

        public static IEnumerable<JobType> ToDomainModels(this IEnumerable<JobTypeModel> JobTypeModels)
        {
            return JobTypeModels.Select(a => a.ToDomainModel());
        }
    }
}
