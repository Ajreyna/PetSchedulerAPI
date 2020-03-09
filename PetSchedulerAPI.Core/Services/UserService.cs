using System;
using System.Collections.Generic;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.Core.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepo;

        // inject an IUserRepository in the constructor
        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User Add(User User)
        {
            // add new user
            _userRepo.Add(User);
            return (User);
        }

        public User Get(int id)
        {
            // get user by id
            return _userRepo.Get(id);
        }

        public User Update(User updatedUser)
        {
            // update the user and save
            var User = _userRepo.Update(updatedUser);
            return User;
        }

        public void Remove(User User)
        {
            // remove the user
            _userRepo.Remove(User);
        }

        public IEnumerable<User> GetAll()
        {
            // return all users using ToList()
            return _userRepo.GetAll();
        }
    }
}
