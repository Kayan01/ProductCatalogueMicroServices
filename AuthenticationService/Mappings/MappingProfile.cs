using AutoMapper;
using Catalogue.AuthenticationService.DTOs;
using Catalogue.AuthenticationService.Entities;

namespace Catalogue.AuthenticationService.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, SignUpRequest>()
                .ReverseMap();

            CreateMap<User, CreateUserDto>()
             .ReverseMap();

            CreateMap<SignUpRequest, CreateUserDto>()
                .ForMember(dest => dest.Password, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordKey, opt => opt.Ignore())
              .ReverseMap();

            CreateMap<SignUpResponse, CreateUserDto>()
            .ReverseMap();

            CreateMap<UserDto, User>()
           .ReverseMap();

            CreateMap<UserSecret, CreateUserDto>()
            .ReverseMap();

            CreateMap <LoginResponse, UserDto>()
             .ReverseMap();
        }
    }
}
