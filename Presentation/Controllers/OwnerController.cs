using FlatMate_Backend.Application.Commands;
using FlatMeat_Backend.Application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlatMate_Backend.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OwnerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterOwner(CreateOwnerDto dto)
        {
            var ownerId = await _mediator.Send(new CreateOwnerCommand { OwnerDto = dto });
            return Ok(ownerId);
        }
    }
}
