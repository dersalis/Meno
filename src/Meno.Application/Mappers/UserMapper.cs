using Meno.Application.DTO;
using Meno.Core.Entities;

namespace Meno.Application.Mappers
{
    public static class UserMapper
    {
        public static UserDto MapToDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name.Value,
                Login = user.Login.Value,
                Email = user.Email.Value,
                RoleName = user.Role.ToString(),
                RoleId = (int)user.Role,
                IsActive = user.IsActive,
                CreateDate = user.CreateDate?.Value,
                CreatedByName = user.CreatedBy is not null ? user.CreatedBy?.Name : "",
                ModifiedDate = user.ModifiedDate?.Value,
                ModifiedBy = user.ModifiedBy is not null ? user.ModifiedBy?.Name : "",
            };
        }
    }
}