﻿using System;
using System.Collections.Generic;
using System.Linq;
using PetSchedulerAPI.Core.Models;

namespace PetSchedulerAPI.ApiModels
{
    public static class UserMappingExtenstions
    {

        public static UserModel ToApiModel(this User User)
        {
            return new UserModel
            {
                Id = User.Id,
                // fill in property mappings
                Name = User.Name,

            };
        }

        public static User ToDomainModel(this UserModel UserModel)
        {
            return new User
            {
                Id = UserModel.Id,
                // fill in property mappings
                Name = UserModel.Name,
            };
        }

        public static IEnumerable<UserModel> ToApiModels(this IEnumerable<User> Users)
        {
            return Users.Select(a => a.ToApiModel());
        }

        public static IEnumerable<User> ToDomainModels(this IEnumerable<UserModel> UserModels)
        {
            return UserModels.Select(a => a.ToDomainModel());
        }
    }
}
