using FlatMeat_Backend.Application.DTOs;
using MediatR;

namespace FlatMeat_Backend.Application.Commands
{
    public class CreateUserCommand : IRequest<UserDto>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
