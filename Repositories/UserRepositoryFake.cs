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
                    Username = "sam_doe",
                    Password = "Secure_Password"
                },
                new User{
                    FirstName = "John",
                    LastName = "Cruise",
                    Username = "john-cruise",
                    Password = "Password"
                },

            };
        }
    }
}