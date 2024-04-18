using Meno.Core.Exceptions;

namespace Meno.Core.ValueObjects
{
    public class InvalidMenuItemPriceException : BaseException
    {
        public InvalidMenuItemPriceException() : base("Price must be equal to or greater than 0.")
        {
            
        }
    }
}