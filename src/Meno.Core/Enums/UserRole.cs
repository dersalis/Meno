using System.ComponentModel;

namespace Meno.Core.Enums
{
    public enum UserRole: int
    {
        [Description("None")]
        None = 0,

        [Description("Admin")]
        Admin = 1,

        [Description("User")]
        User = 2,
    }
}