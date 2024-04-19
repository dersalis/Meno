using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class MenuItemDescriptionTests
    {
        [Fact]
        public async Task Create_MenuItemDescription_With_Empty_String_Should_Throw_EmptyMenuItemDescriptionException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new MenuItemDescription(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuItemDescriptionException>();
        }

        [Fact]
        public async Task Create_MenuItemDescription_With_String_Longer_Than_1000_Characters_Should_Throw_InvalidMenuItemDescriptionException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 1001).ToArray());

            // Act
            var exception = Record.Exception(() => new MenuItemDescription(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuItemDescriptionException>();
        }

        [Fact]
        public async Task Create_MenuItemDescription_With_Valid_String_Should_Return_MenuItemDescription()
        {
            // Arrange
            var validString = "description";

            // Act
            var description = new MenuItemDescription(validString);

            // Assert
            description.ShouldNotBeNull();
            description.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_MenuItemDescription_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "description";
            var description = new MenuItemDescription(validString);

            // Act
            string descriptionString = description;

            // Assert
            descriptionString.ShouldNotBeNull();
            descriptionString.ShouldBe(validString);
        }
        
    }
}