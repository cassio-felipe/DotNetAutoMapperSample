using System;
using AutoMapper;
using DotNetAutoMapperSample.Dtos;
using DotNetAutoMapperSample.Models;

namespace DotNetAutoMapperSample
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>()
                .ReverseMap();
            
            CreateMap<User, PersonDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.IsAdult, opt => opt.MapFrom(src => (DateTime.Now.Year - src.BirthDate.Year) >= 18? true : false))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => (DateTime.Now.Year - src.BirthDate.Year)));
        }    
    }
}