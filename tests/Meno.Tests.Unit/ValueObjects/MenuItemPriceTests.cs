using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class MenuItemPriceTests
    {
        [Fact]
        public async Task Create_MenuItemPrice_With_Zero_Should_Throw_InvalidMenuItemPriceException()
        {
            // Arrange
            var zero = 0m;

            // Act
            var exception = Record.Exception(() => new MenuItemPrice(zero));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuItemPriceException>();
        }

        [Fact]
        public async Task Create_MenuItemPrice_With_Negative_Value_Should_Throw_InvalidMenuItemPriceException()
        {
            // Arrange
            var negativeValue = -1m;

            // Act
            var exception = Record.Exception(() => new MenuItemPrice(negativeValue));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuItemPriceException>();
        }

        [Fact]
        public async Task Create_MenuItemPrice_With_Valid_Value_Should_Return_MenuItemPrice()
        {
            // Arrange
            var validValue = 1m;

            // Act
            var price = new MenuItemPrice(validValue);

            // Assert
            price.ShouldNotBeNull();
            price.Value.ShouldBe(validValue);
        }
    }
}