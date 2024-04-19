namespace Meno.Core.Exceptions
{
    public class EmptyPhoneException : BaseException
    {
        public EmptyPhoneException() : base("Phone number is empty.")
        {
            
        }
    }
}