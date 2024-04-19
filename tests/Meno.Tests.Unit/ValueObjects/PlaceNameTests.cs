using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class PlaceNameTests
    {
        [Fact]
        public async Task Create_PlaceName_With_Empty_String_Should_Throw_InvalidPlaceNameException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new PlaceName(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidPlaceNameException>();
        }

        [Fact]
        public async Task Create_PlaceName_With_String_Longer_Than_100_Characters_Should_Throw_InvalidPlaceNameException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new PlaceName(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidPlaceNameException>();
        }

        [Fact]
        public async Task Create_PlaceName_With_Valid_String_Should_Return_PlaceName()
        {
            // Arrange
            var validString = "place name";

            // Act
            var placeName = new PlaceName(validString);

            // Assert
            placeName.ShouldNotBeNull();
            placeName.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_PlaceName_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "place name";
            var placeName = new PlaceName(validString);

            // Act
            string placeNameString = placeName;

            // Assert
            placeNameString.ShouldBe(validString);
        }
    }
}