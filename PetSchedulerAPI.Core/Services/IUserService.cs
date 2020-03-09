using System;
using System.Collections.Generic;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.Core.Services
{
    public interface IUserService
    {
        // Create
        User Add(User User);
        // Read
        User Get(int id);
        // Update
        User Update(User updatedUser);
        // Delete
        void Remove(User User);
        // List
        IEnumerable<User> GetAll();
    }
}
