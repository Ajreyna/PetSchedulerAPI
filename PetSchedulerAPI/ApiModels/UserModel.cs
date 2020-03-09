using System;
using System.Collections.Generic;

namespace PetSchedulerAPI.ApiModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserModel> Activities { get; set; }
    }
}
