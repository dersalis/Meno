using Meno.Core.Exceptions;

namespace Meno.Core.ValueObjects
{
    public sealed record MenuItemDescription
    {
        public string Value { get; }

        public MenuItemDescription(string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length > 1000)
            {
                throw new InvalidMenuItemDescriptionException();
            }

            Value = value;
        }

        public static implicit operator string(MenuItemDescription description) => description.Value;
        public static implicit operator MenuItemDescription(string description) => new(description);
    }
}