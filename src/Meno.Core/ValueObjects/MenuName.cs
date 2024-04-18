using Meno.Core.Exceptions;

namespace Meno.Core.ValueObjects
{
    public sealed record MenuName
    {
        public string Value { get; }

        public MenuName(string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length > 100)
            {
                throw new InvalidMenuNameException();
            }

            Value = value;
        }

        public static implicit operator string(MenuName name) => name.Value;
        public static implicit operator MenuName(string name) => new(name);
    }
}