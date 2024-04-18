using Meno.Core.Exceptions;

namespace Meno.Core.ValueObjects
{
    public sealed record CategoryDescription
    {
        public string Value { get; }

        public CategoryDescription(string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length > 1000)
            {
                throw new InvalidCategoryDescriptionException();
            }

            Value = value;
        }

        public static implicit operator string(CategoryDescription description) => description.Value;
        public static implicit operator CategoryDescription(string description) => new(description);
    }
}