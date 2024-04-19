using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class UserNameTests
    {
        [Fact]
        public async Task Create_UserName_With_Empty_String_Should_Throw_InvalidUserNameException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new UserName(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidUserNameException>();
        }

        [Fact]
        public async Task Create_UserName_With_String_Longer_Than_100_Characters_Should_Throw_InvalidUserNameException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new UserName(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidUserNameException>();
        }

        [Fact]
        public async Task Create_UserName_With_Valid_String_Should_Return_UserName()
        {
            // Arrange
            var validString = "name";

            // Act
            var name = new UserName(validString);

            // Assert
            name.ShouldNotBeNull();
            name.Value.ShouldBe(validString);
        }

        [Fact]
        public async Task Implicit_Conversion_From_UserName_To_String_Should_Return_String()
        {
            // Arrange
            var validString = "name";
            var name = new UserName(validString);

            // Act
            string nameString = name;

            // Assert
            nameString.ShouldBe(validString);
        }
    }
}