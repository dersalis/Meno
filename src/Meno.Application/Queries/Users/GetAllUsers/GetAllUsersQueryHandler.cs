using MediatR;
using Meno.Application.DTO;
using Meno.Application.Mappers;
using Meno.Core.Entities;
using Meno.Infrastructure.Abstractions;

namespace Meno.Application.Queries.Users.GetAllUsers
{
    internal sealed class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDto>>
    {
        private readonly IRepository<User> _userRepository;

        public GetAllUsersQueryHandler(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllAsync();

            return users.Select(u => u.MapToDto());
        }
    }
}