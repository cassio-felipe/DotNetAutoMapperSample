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
            CreateMap<User, PersonDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
        }    
    }
}