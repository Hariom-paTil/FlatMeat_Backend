using FlatMeat_Backend.Application.Commands;
using FlatMeat_Backend.Application.DTOs;

namespace FlatMeat_Backend.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> CreateUserAsync(CreateUserCommand command);
    }
}
