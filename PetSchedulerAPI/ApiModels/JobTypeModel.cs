using System;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.ApiModels
{
    public class JobTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RecordType RecordType { get; set; }
    }
}
