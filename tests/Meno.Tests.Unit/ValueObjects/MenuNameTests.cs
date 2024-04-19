using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class MenuNameTests
    {
        [Fact]
        public async Task Create_MenuName_With_Empty_String_Should_Throw_EmptyMenuNameException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new MenuName(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuNameException>();
        }

        [Fact]
        public async Task Create_MenuName_With_String_Longer_Than_100_Characters_Should_Throw_InvalidMenuNameException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new MenuName(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuNameException>();
        }

        [Fact]
        public async Task Create_MenuName_With_Valid_String_Should_Return_MenuName()
        {
            // Arrange
            var validString = "name";

            // Act
            var name = new MenuName(validString);

            // Assert
            name.ShouldNotBeNull();
            name.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_MenuName_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "name";
            var name = new MenuName(validString);

            // Act
            string nameString = name;

            // Assert
            nameString.ShouldBe(validString);
        }
    }
}