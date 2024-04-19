using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class PostalCodeTests
    {
        [Fact]
        public async Task Create_PostalCode_With_Empty_String_Should_Throw_EmptyPostalCodeException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new PostalCode(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<EmptyPostalCodeException>();
        }

        [Fact]
        public async Task Create_PostalCode_With_String_Longer_Than_100_Characters_Should_Throw_InvalidPostalCodeException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new PostalCode(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidPostalCodeException>();
        }

        [Fact]
        public async Task Create_PostalCode_With_Invalid_String_Should_Throw_InvalidPostalCodeException()
        {
            // Arrange
            var invalidString = "invalid";

            // Act
            var exception = Record.Exception(() => new PostalCode(invalidString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidPostalCodeException>();
        }

        [Fact]
        public async Task Create_PostalCode_With_Valid_String_Should_Return_PostalCode()
        {
            // Arrange
            var validString = "00-000";

            // Act
            var postalCode = new PostalCode(validString);

            // Assert
            postalCode.ShouldNotBeNull();
            postalCode.Value.ShouldBe(validString);
        }
    }
}