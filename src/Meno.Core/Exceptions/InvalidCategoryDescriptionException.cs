namespace Meno.Core.Exceptions
{
    public class InvalidCategoryDescriptionException : BaseException
    {
        public InvalidCategoryDescriptionException() 
            : base("Category description cannot be empty, null or longer than 1000 characters.")
        {
            
        }
    }
}