using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class AddressTests
    {
        [Fact]
        public async Task Create_Address_With_Empty_String_Should_Throw_InvalidCompanyAddressException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new Address(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCompanyAddressException>();
        }
        
        [Fact]
        public async Task Create_Address_With_String_Longer_Than_100_Characters_Should_Throw_InvalidCompanyAddressException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new Address(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCompanyAddressException>();
        }

        [Fact]
        public async Task Create_Address_With_Valid_String_Should_Return_Address()
        {
            // Arrange
            var validString = "address";

            // Act
            var address = new Address(validString);

            // Assert
            address.ShouldNotBeNull();
            address.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_Address_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "address";
            var address = new Address(validString);

            // Act
            string addressString = address;

            // Assert
            addressString.ShouldBe(validString);
        }
    }
}