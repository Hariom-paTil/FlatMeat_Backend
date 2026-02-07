using FlatMate_Backend.Application.Commands;
using FlatMate_Backend.Application.DTOs;
using FlatMate_Backend.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlatMate_Backend.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoomController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddRoom(CreateRoomDto dto)
        {
            var roomId = await _mediator.Send(new CreateRoomCommand { RoomDto = dto });
            return Ok(roomId);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRooms()
        {
            var result = await _mediator.Send(new GetRoomListQuery());
            return Ok(result);
        }

    }
}
