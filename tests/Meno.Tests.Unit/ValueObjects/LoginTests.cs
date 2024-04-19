using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class LoginTests
    {
        [Fact]
        public async Task Create_Login_With_Empty_String_Should_Throw_EmptyLoginException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new Login(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidLoginException>();
        }

        [Fact]
        public async Task Create_Login_With_String_Shorter_Than_3_Characters_Should_Throw_InvalidLoginException()
        {
            // Arrange
            var shortString = "ab";

            // Act
            var exception = Record.Exception(() => new Login(shortString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidLoginException>();
        }

        [Fact]
        public async Task Create_Login_With_String_Longer_Than_100_Characters_Should_Throw_InvalidLoginException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new Login(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidLoginException>();
        }

        [Fact]
        public async Task Create_Login_With_Valid_String_Should_Return_Login()
        {
            // Arrange
            var validString = "login";

            // Act
            var login = new Login(validString);

            // Assert
            login.ShouldNotBeNull();
            login.Value.ShouldBe(validString);
        }
    }
}