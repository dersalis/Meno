using Meno.Core.Enums;
using Meno.Core.ValueObjects;

namespace Meno.Core.Entities
{
    public class User : BaseEntity
    {
        public UserName Name { get; private set; }
        public Login Login { get; private set; }    
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public UserRole Role { get; private set; }

        public User(UserName name, Login login, Email email, Password password)
            : base(null, null, null, null)
        {
            Name = name;
            Login = login;
            Email = email;
            Password = password;
            Role = UserRole.User;
        }

        public void ChangeName(string name)
        {
            Name = new UserName(name);
        }

        public void ChangeLogin(string login)
        {
            Login = new Login(login);
        }

        public void ChangeEmail(string email)
        {
            Email = new Email(email);
        }

        public void ChangePassword(string password)
        {
            Password = new Password(password);
        }

        public void ChangeRole(UserRole role)
        {
            Role = role;
        }
    }
}