namespace Meno.Core.Exceptions
{
    public class InvalidUserNameException : BaseException
    {
        public InvalidUserNameException(string userName) : base($"Invalid user name: {userName}")
        {
            
        }
    }
}