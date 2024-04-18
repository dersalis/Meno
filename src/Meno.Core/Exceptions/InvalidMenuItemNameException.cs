namespace Meno.Core.Exceptions
{
    public class InvalidMenuItemNameException : BaseException
    {
        public InvalidMenuItemNameException() : base("Menu item name cannot be empty, null or longer than 100 characters.")
        {
            
        }
    }
}