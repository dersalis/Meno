using Meno.Core.Exceptions;

namespace Meno.Core.ValueObjects
{
    public sealed record MenuItemName
    {
        public string Value { get; }

        public MenuItemName(string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length > 100)
            {
                throw new InvalidMenuItemNameException();
            }

            Value = value;
        }

        public static implicit operator string(MenuItemName description) => description.Value;
        public static implicit operator MenuItemName(string description) => new(description);
    }
}