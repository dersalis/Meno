using MediatR;
using Meno.Application.DTO;

namespace Meno.Application.Queries.Users.GetAllUsers
{
    public class GetAllUsersQuery: IRequest<IEnumerable<UserDto>>
    {
        
    }
}