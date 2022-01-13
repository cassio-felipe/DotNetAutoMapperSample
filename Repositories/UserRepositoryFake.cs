using System;
using System.Collections.Generic;
using DotNetAutoMapperSample.Models;

namespace DotNetAutoMapperSample.Repositories
{
    public static class UserRepositoryFake
    {
        public static List<User> GetAll()
        {
            return new()
            {
                new User
                {
                    FirstName = "Sam",
                    LastName = "Doe",
                    BirthDate = DateTime.Parse("2015-07-04"),
                    Username = "sam_doe",
                    Password = "Secure_Password"
                },
                new User{
                    FirstName = "John",
                    LastName = "Cruise",
                    BirthDate = DateTime.Parse("2000-07-04"),
                    Username = "john-cruise",
                    Password = "Password"
                },

            };
        }
    }
}