using Meno.Core.Exceptions;

namespace Meno.Core.ValueObjects
{
    public sealed record PlaceName
    {
        public string Value { get; }

        public PlaceName(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 100)
            {
                throw new InvalidPlaceNameException(value);
            }

            Value = value;
        }

        public static implicit operator string(PlaceName companyName) => companyName.Value;
        public static implicit operator PlaceName(string companyName) => new(companyName);
    }
}