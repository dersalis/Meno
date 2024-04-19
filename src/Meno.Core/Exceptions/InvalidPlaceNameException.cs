namespace Meno.Core.Exceptions
{
    public class InvalidPlaceNameException : BaseException
    {
        public InvalidPlaceNameException(string value) 
            : base($"Invalid place name: {value}")
        {
            
        }
    }
}