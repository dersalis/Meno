using Meno.Core.Enums;

namespace Meno.Application.DTO
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; }
        public string Login { get; set; }    
        public string Email { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
    }
}