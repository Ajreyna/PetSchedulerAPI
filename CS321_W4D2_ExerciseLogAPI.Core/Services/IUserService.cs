using System;
using System.Collections.Generic;
using CS321_W4D2_ExerciseLogAPI.Core.Models;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
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
