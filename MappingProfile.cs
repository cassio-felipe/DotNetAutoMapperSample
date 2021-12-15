using AutoMapper;
using DotNetAutoMapperSample.Dtos;
using DotNetAutoMapperSample.Models;

namespace DotNetAutoMapperSample
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }    
    }
}