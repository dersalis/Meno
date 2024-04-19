using Meno.Core.Exceptions;

namespace Meno.Core.ValueObjects
{
    public sealed record MenuItemPrice
    {
        public decimal Value { get; }

        public MenuItemPrice(decimal value)
        {
            if(value <= 0)
            {
                throw new InvalidMenuItemPriceException();
            }

            Value = value;
        }

        public static implicit operator decimal(MenuItemPrice price) => price.Value;
        public static implicit operator MenuItemPrice(decimal price) => new(price);

        public override string ToString() => Value.ToString("C");
    }
}