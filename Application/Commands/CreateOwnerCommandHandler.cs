using AutoMapper;
using FlatMeat_Backend.Domain.Entities;
using FlatMeat_Backend.Infrastructure.Repositories;
using MediatR;

namespace FlatMate_Backend.Application.Commands
{
    public class CreateOwnerCommandHandler : IRequestHandler<CreateOwnerCommand, int>
    {
        private readonly IRepository<OwnerPersonalInfo> _repository;
        private readonly IMapper _mapper;

        public CreateOwnerCommandHandler(
            IRepository<OwnerPersonalInfo> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateOwnerCommand request, CancellationToken cancellationToken)
        {
            var owner = _mapper.Map<OwnerPersonalInfo>(request.OwnerDto);
            await _repository.AddRoomAsync(owner);
            return owner.OwnerId;
        }

    }
}
