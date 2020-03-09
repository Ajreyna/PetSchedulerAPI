using System;
using System.ComponentModel.DataAnnotations;

namespace PetSchedulerAPI.ApiModels
{
    public class JobDetailsModel
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int JobDetailsTypeId { get; set; }
        // TODO: Make JobDetailsType a string property that will contain the name of the JobDetails type (update the mapping code)
        public string JobDetailsType { get; set; }

        [Required]
        public double Duration { get; set; }
        public double Distance { get; set; }

        [Required]
        public int UserId { get; set; }
        // TODO: Make User a string property that will contain the User's name (updating the mapping code)
        public string User { get; set; }

        public string Notes { get; set; }
    }
}
