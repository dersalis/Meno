namespace Meno.Core.Exceptions
{
    public class InvalidMenuDescriptionException : BaseException
    {
        public InvalidMenuDescriptionException() : base("Menu description cannot be empty, null or longer than 1000 characters.")
        {
            
        }
    }
}