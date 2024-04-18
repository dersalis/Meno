using Meno.Core.Exceptions;

namespace Meno.Core.ValueObjects
{
    public sealed record MenuDescription
    {
        public string Value { get; }

        public MenuDescription(string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length > 1000)
            {
                throw new InvalidMenuDescriptionException();
            }

            Value = value;
        }

        public static implicit operator string(MenuDescription description) => description.Value;
        public static implicit operator MenuDescription(string description) => new(description);
    }
}