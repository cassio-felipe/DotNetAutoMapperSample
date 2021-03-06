using System.Collections.Generic;
using AutoMapper;
using DotNetAutoMapperSample.Dtos;
using DotNetAutoMapperSample.Repositories;
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
}