using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class MenuItemNameTests
    {
        [Fact]
        public async Task Create_MenuItemName_With_Empty_String_Should_Throw_EmptyMenuItemNameException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new MenuItemName(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuItemNameException>();
        }

        [Fact]
        public async Task Create_MenuItemName_With_String_Longer_Than_100_Characters_Should_Throw_InvalidMenuItemNameException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new MenuItemName(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuItemNameException>();
        }

        [Fact]
        public async Task Create_MenuItemName_With_Valid_String_Should_Return_MenuItemName()
        {
            // Arrange
            var validString = "name";

            // Act
            var name = new MenuItemName(validString);

            // Assert
            name.ShouldNotBeNull();
            name.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_MenuItemName_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "name";
            var name = new MenuItemName(validString);

            // Act
            string nameString = name;

            // Assert
            nameString.ShouldBe(validString);
        }
    }
}