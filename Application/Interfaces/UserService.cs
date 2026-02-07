using AutoMapper;
using FlatMeat_Backend.Application.Commands;
using FlatMeat_Backend.Application.DTOs;
using FlatMeat_Backend.Domain.Entities;
using FlatMeat_Backend.Infrastructure.Repositories;

namespace FlatMeat_Backend.Application.Interfaces
{
    public class UserService : IUserService
    {
        private readonly IRepository<Users> _repository;
        private readonly IMapper _mapper;

        public UserService(IRepository<Users> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UserDto> CreateUserAsync(CreateUserCommand command)
        {
            var user = _mapper.Map<Users>(command);

            await _repository.AddAsync(user);
            await _repository.SaveAsync();

            return _mapper.Map<UserDto>(user);
        }
    }
}
