using System;
using System.Collections.Generic;

namespace PetSchedulerAPI.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<JobDetails> JobDetails2 { get; set; }
    }
}
