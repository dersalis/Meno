using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class EmailTests
    {
        [Fact]
        public async Task Create_Email_With_Empty_String_Should_Throw_EmptyEmailException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new Email(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<EmptyEmailException>();
        }

        [Fact]
        public async Task Create_Email_With_String_Longer_Than_100_Characters_Should_Throw_InvalidEmailException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new Email(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidEmailException>();
        }

        [Fact]
        public async Task Create_Email_With_Invalid_String_Should_Throw_InvalidEmailException()
        {
            // Arrange
            var invalidString = "invalid.email";

            // Act
            var exception = Record.Exception(() => new Email(invalidString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidEmailException>();
        }

        [Fact]
        public async Task Create_Email_With_Valid_String_Should_Return_Email()
        {
            // Arrange
            var validString = "test@meil.com";

            // Act
            var email = new Email(validString);

            // Assert
            email.ShouldNotBeNull();
            email.Value.ShouldBe(validString);
        }
    }
}