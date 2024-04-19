using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class CityTests
    {
        [Fact]
        public async Task Create_City_With_Empty_String_Should_Throw_InvalidCityException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new City(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCompanyCityException>();
        }
        
        [Fact]
        public async Task Create_City_With_String_Longer_Than_100_Characters_Should_Throw_InvalidCityException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new City(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCompanyCityException>();
        }

        [Fact]
        public async Task Create_City_With_Valid_String_Should_Return_City()
        {
            // Arrange
            var validString = "city";

            // Act
            var city = new City(validString);

            // Assert
            city.ShouldNotBeNull();
            city.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_City_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "city";
            var city = new City(validString);

            // Act
            string cityString = city;

            // Assert
            cityString.ShouldBe(validString);
        }
    }
}