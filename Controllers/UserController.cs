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
        private readonly List<User> _users; 
            
        public UserController(ILogger<UserController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _users = FillUser();
        }

        [HttpGet]
        public IEnumerable<UserDto> GetAll()
        {
            var usersDto = _mapper.Map<List<UserDto>>(_users);
            return usersDto;
        }
        
        private List<User> FillUser()
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