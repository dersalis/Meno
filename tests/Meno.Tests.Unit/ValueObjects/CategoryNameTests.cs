using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class CategoryNameTests
    {
        [Fact]
        public async Task Create_CategoryName_With_Empty_String_Should_Throw_InvalidCategoryNameException()
        {
            // Arrange
            var emptyString = string.Empty;

            // Act
            var exception = Record.Exception(() => new CategoryName(emptyString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCategoryNameException>();
        }

        [Fact]
        public async Task Create_CategoryName_With_Whitespace_String_Should_Throw_InvalidCategoryNameException()
        {
            // Arrange
            var whitespaceString = " ";

            // Act
            var exception = Record.Exception(() => new CategoryName(whitespaceString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCategoryNameException>();
        }
        
        [Fact]
        public async Task Create_CategoryName_With_String_Longer_Than_100_Characters_Should_Throw_InvalidCategoryNameException()
        {
            // Arrange
            var longString = new string(Enumerable.Repeat('a', 101).ToArray());

            // Act
            var exception = Record.Exception(() => new CategoryName(longString));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidCategoryNameException>();
        }

        [Fact]
        public async Task Create_CategoryName_With_Valid_String_Should_Return_CategoryName()
        {
            // Arrange
            var validString = "Category Name";

            // Act
            var categoryName = new CategoryName(validString);

            // Assert
            categoryName.ShouldNotBeNull();
            categoryName.Value.ShouldBe(validString);
        }
        
    }
}