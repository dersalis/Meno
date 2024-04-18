namespace Meno.Core.Exceptions
{
    public class InvalidEmailException : BaseException
    {
        public InvalidEmailException(string email) : base($"Invalid email address: {email}")
        {}
    }
}