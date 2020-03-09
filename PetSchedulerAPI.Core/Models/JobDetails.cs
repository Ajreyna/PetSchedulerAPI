using System;
namespace PetSchedulerAPI.Core.Models
{
    public class JobDetails
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
        public double Duration { get; set; }
        public double Distance { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Notes { get; set; }
    }
}
