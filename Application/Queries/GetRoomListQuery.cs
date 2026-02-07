using FlatMate_Backend.Application.DTOs;
using MediatR;

namespace FlatMate_Backend.Application.Queries
{
    public class GetRoomListQuery : IRequest<List<RoomResponseDto>>
    {

    }
}
