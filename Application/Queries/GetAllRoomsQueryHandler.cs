using AutoMapper;
using FlatMate_Backend.Application.DTOs;
using FlatMeat_Backend.Domain.Entities;
using FlatMeat_Backend.Infrastructure.Repositories;
using MediatR;

namespace FlatMate_Backend.Application.Queries

{
    public class GetAllRoomsQueryHandler : IRequestHandler<GetRoomListQuery, List<RoomResponseDto>>
    {
        private readonly IRepository<RoomData> _roomRepository;
        private readonly IMapper _mapper;

        public GetAllRoomsQueryHandler(
            IRepository<RoomData> roomRepository,
            IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public async Task<List<RoomResponseDto>> Handle(
            GetRoomListQuery request,
            CancellationToken cancellationToken)
        {
            var rooms = await _roomRepository.GetAllAsync();
            return _mapper.Map<List<RoomResponseDto>>(rooms);
        }


    }
}
