namespace Meno.Core.Exceptions
{
    public class InvalidMenuNameException : BaseException
    {
        public InvalidMenuNameException() : base("Menu name cannot be empty, null or longer than 100 characters.")
        {
            
        }
    }
}