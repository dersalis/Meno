using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class PasswordTests
    {
        [Fact]
        public async Task Create_Password_With_Empty_String_Should_Throw_InvalidPasswordException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new Password(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidPasswordException>();
        }

        [Fact]
        public async Task Create_Password_With_String_Shorter_Than_8_Characters_Should_Throw_InvalidPasswordException()
        {
            // Arrange
            var shortString = "1234567";

            // Act
            var exception = Record.Exception(() => new Password(shortString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidPasswordException>();
        }

        [Fact]
        public async Task Create_Password_With_Valid_String_Should_Return_Password()
        {
            // Arrange
            var validString = "password";

            // Act
            var password = new Password(validString);

            // Assert
            password.ShouldNotBeNull();
            password.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_Password_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "password";
            var password = new Password(validString);

            // Act
            string passwordString = password;

            // Assert
            passwordString.ShouldBe(validString);
        }
        
    }
}