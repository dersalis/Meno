using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class CategoryDescriptionTests
    {
        [Fact]
        public async Task Create_CategoryDescription_With_Empty_String_Should_Throw_InvalidCategoryDescriptionException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new CategoryDescription(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCategoryDescriptionException>();
        }

        [Fact]
        public async Task Create_CategoryDescription_With_Whitespace_String_Should_Throw_InvalidCategoryDescriptionException()
        {
            // Arrange
            var whitespaceString = " ";

            // Act
            var exception = Record.Exception(() => new CategoryDescription(whitespaceString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCategoryDescriptionException>();
        }

        [Fact]
        public async Task Create_CategoryDescription_With_String_Longer_Than_1000_Characters_Should_Throw_InvalidCategoryDescriptionException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 1001).ToArray());

            // Act
            var exception = Record.Exception(() => new CategoryDescription(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCategoryDescriptionException>();
        }

        [Fact]
        public async Task Create_CategoryDescription_With_Valid_String_Should_Return_CategoryDescription()
        {
            // Arrange
            var validString = "Category Description";

            // Act
            var categoryDescription = new CategoryDescription(validString);

            // Assert
            categoryDescription.ShouldNotBeNull();
            categoryDescription.Value.ShouldBe(validString);
        }
    }
}