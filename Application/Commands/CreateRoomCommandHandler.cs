using AutoMapper;
using FlatMeat_Backend.Domain.Entities;
using FlatMeat_Backend.Infrastructure.Repositories;
using MediatR;

namespace FlatMate_Backend.Application.Commands
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, int>
    {
        private readonly IRepository<RoomData> _repository;
        private readonly IMapper _mapper;

        public CreateRoomCommandHandler(
            IRepository<RoomData> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            var room = _mapper.Map<RoomData>(request.RoomDto);
            await _repository.AddRoomAsync(room);
            return room.RoomId;
        }
    }
}
