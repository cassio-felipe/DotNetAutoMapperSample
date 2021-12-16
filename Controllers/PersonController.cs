using System.Collections.Generic;
using AutoMapper;
using DotNetAutoMapperSample.Dtos;
using DotNetAutoMapperSample.Models;
using DotNetAutoMapperSample.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotNetAutoMapperSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILogger<PersonController> _logger;
            
        public PersonController(ILogger<PersonController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<PersonDto> GetAll()
        {
            var persons = UserRepositoryFake.GetAll();
            var personsDto = _mapper.Map<List<PersonDto>>(persons);
            return personsDto;
        }
    }
}