using System.Collections.Generic;
using AutoMapper;
using DotNetAutoMapperSample.Dtos;
using DotNetAutoMapperSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotNetAutoMapperSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILogger<UserController> _logger;
            
        public UserController(ILogger<UserController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<UserDto> GetAll()
        {
            var users = UserRepositoryFake.GetAll();
            var usersDto = _mapper.Map<List<UserDto>>(users);
            return usersDto;
        }
    }

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