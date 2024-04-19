using Meno.Core.Exceptions;

namespace Meno.Core.ValueObjects
{
    public sealed record PlaceDescription
    {
        public string Value { get; }

        public PlaceDescription(string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length > 1000)
            {
                throw new InvalidPlaceDescriptionException();
            }

            Value = value;
        }

        public static implicit operator string(PlaceDescription description) => description.Value;
        public static implicit operator PlaceDescription(string description) => new(description);
    }
}