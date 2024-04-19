using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class CountryTests
    {
        [Fact]
        public async Task Create_Country_With_Empty_String_Should_Throw_InvalidCompanyCountryException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new Country(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCompanyCountryException>();
        }
        
        [Fact]
        public async Task Create_Country_With_String_Longer_Than_100_Characters_Should_Throw_InvalidCompanyCountryException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new Country(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCompanyCountryException>();
        }

        [Fact]
        public async Task Create_Country_With_Valid_String_Should_Return_Country()
        {
            // Arrange
            var validString = "country";

            // Act
            var country = new Country(validString);

            // Assert
            country.ShouldNotBeNull();
            country.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_Country_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "country";
            var country = new Country(validString);

            // Act
            string countryString = country;

            // Assert
            countryString.ShouldBe(validString);
        }
    }
}