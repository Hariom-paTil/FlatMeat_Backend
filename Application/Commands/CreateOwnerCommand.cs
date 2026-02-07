using FlatMeat_Backend.Application.DTOs;
using MediatR;

namespace FlatMate_Backend.Application.Commands
{
    public class CreateOwnerCommand : IRequest<int>
    {
        public CreateOwnerDto OwnerDto { get; set; }
    }
}
