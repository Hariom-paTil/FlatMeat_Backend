using AutoMapper;
using FlatMate_Backend.Application.DTOs;
using FlatMeat_Backend.Application.Commands;
using FlatMeat_Backend.Application.DTOs;
using FlatMeat_Backend.Domain.Entities;

namespace FlatMeat_Backend.Application.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserCommand, Users>();
            CreateMap<Users, UserDto>().ReverseMap();
            CreateMap<CreateOwnerDto, OwnerPersonalInfo>();
            CreateMap<CreateRoomDto, RoomData>();
            CreateMap<RoomData, RoomResponseDto>().ReverseMap();

        }
    }
}
