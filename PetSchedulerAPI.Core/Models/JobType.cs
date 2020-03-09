using System;
namespace PetSchedulerAPI.Core.Models
{
        public enum RecordType
        {
            DurationOnly, // only record duration
            DurationAndDistance // record duration and distance
        }

        public class JobType
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public RecordType RecordType { get; set; }
        }
}
