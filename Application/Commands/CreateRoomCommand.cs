using FlatMate_Backend.Application.DTOs;
using MediatR;

namespace FlatMate_Backend.Application.Commands
{
    public class CreateRoomCommand : IRequest<int>
    {

        public CreateRoomDto RoomDto { get; set; }
    }
}
