using Meno.Core.Exceptions;

namespace Meno.Core.ValueObjects
{
    public sealed record CategoryName
    {
        public string Value { get; }

        public CategoryName(string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length > 100)
            {
                throw new InvalidCategoryNameException();
            }

            Value = value;
        }

        public static implicit operator string(CategoryName description) => description.Value;
        public static implicit operator CategoryName(string description) => new(description);
    }
}