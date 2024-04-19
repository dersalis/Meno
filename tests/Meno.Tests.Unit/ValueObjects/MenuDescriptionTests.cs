using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class MenuDescriptionTests
    {
        [Fact]
        public async Task Create_MenuDescription_With_Empty_Value_Should_Throw_InvalidMenuDescriptionException()
        {
            // Arrange
            var emptyValue = string.Empty;

            // Act
            var exception = Record.Exception(() => new MenuDescription(emptyValue));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuDescriptionException>();
        }

        [Fact]
        public async Task Create_MenuDescription_With_Null_Value_Should_Throw_InvalidMenuDescriptionException()
        {
            // Arrange
            string nullValue = null;

            // Act
            var exception = Record.Exception(() => new MenuDescription(nullValue));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuDescriptionException>();
        }

        [Fact]
        public async Task Create_MenuDescription_With_Valid_Value_Should_Return_MenuDescription()
        {
            // Arrange
            var value = "Menu description";

            // Act
            var description = new MenuDescription(value);

            // Assert
            description.ShouldNotBeNull();
            description.Value.ShouldBe(value);
        }

        [Fact]
        public async Task Create_MenuDescription_With_Value_Longer_Than_1000_Characters_Should_Throw_InvalidMenuDescriptionException()
        {
            // Arrange
            var value = new string(Enumerable.Repeat('a', 1001).ToArray());

            // Act
            var exception = Record.Exception(() => new MenuDescription(value));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidMenuDescriptionException>();
        }
    }
}