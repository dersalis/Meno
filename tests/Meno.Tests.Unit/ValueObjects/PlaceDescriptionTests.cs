using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class PlaceDescriptionTests
    {
        [Fact]
        public async Task Create_PlaceDescription_With_Empty_String_Should_Throw_InvalidPlaceDescriptionException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new PlaceDescription(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidPlaceDescriptionException>();
        }

        [Fact]
        public async Task Create_PlaceDescription_With_String_Longer_Than_1000_Characters_Should_Throw_InvalidPlaceDescriptionException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 1001).ToArray());

            // Act
            var exception = Record.Exception(() => new PlaceDescription(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidPlaceDescriptionException>();
        }

        [Fact]
        public async Task Create_PlaceDescription_With_Valid_String_Should_Return_PlaceDescription()
        {
            // Arrange
            var validString = "place description";

            // Act
            var placeDescription = new PlaceDescription(validString);

            // Assert
            placeDescription.ShouldNotBeNull();
            placeDescription.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_PlaceDescription_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "place description";
            var placeDescription = new PlaceDescription(validString);

            // Act
            string placeDescriptionString = placeDescription;

            // Assert
            placeDescriptionString.ShouldBe(validString);
        }
    }
}