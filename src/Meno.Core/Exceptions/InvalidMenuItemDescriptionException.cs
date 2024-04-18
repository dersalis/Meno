namespace Meno.Core.Exceptions
{
    public class InvalidMenuItemDescriptionException : BaseException
    {
        public InvalidMenuItemDescriptionException() : base("Menu item description cannot be empty, null or longer than 1000 characters.")
        {
            
        }
    }
}