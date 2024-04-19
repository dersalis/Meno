using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class PhoneTests
    {
        [Fact]
        public async Task Create_Phone_With_Empty_String_Should_Throw_InvalidPhoneException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new Phone(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<EmptyPhoneException>();
        }

        [Fact]
        public async Task Create_Phone_With_String_Longer_Than_100_Characters_Should_Throw_PhoneToLongException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new Phone(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<PhoneToLongException>();
        }

        [Fact]
        public async Task Create_Phone_With_Invalid_String_Should_Throw_InvalidPhoneException()
        {
            // Arrange
            var invalidString = "invalid";

            // Act
            var exception = Record.Exception(() => new Phone(invalidString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidPhoneException>();
        }

        [Fact]
        public async Task Create_Phone_With_Valid_String_Should_Return_Phone()
        {
            // Arrange
            var validString = "+48123456789";

            // Act
            var phone = new Phone(validString);

            // Assert
            phone.ShouldNotBeNull();
            phone.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_Phone_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "+48123456789";
            var phone = new Phone(validString);

            // Act
            string phoneString = phone;

            // Assert
            phoneString.ShouldBe(validString);
        }
    }
}