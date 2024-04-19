namespace Meno.Core.Exceptions
{
    public class InvalidPlaceDescriptionException : BaseException
    {
        public InvalidPlaceDescriptionException() : base("Place description cannot be empty, null or longer than 1000 characters.")
        {
            
        }
    }
}