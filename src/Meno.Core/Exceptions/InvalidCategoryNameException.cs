namespace Meno.Core.Exceptions
{
    public class InvalidCategoryNameException : BaseException
    {
        public InvalidCategoryNameException() 
            : base("Category name cannot be empty, null or longer than 100 characters."){}
    }
}