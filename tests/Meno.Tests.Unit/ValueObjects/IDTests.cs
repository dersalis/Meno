using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class IDTests
    {
        [Fact]
        public async Task Create_ID_With_Empty_Guid_Should_Throw_EmptyIDException()
        {
            // Arrange
            var emptyGuid = Guid.Empty;

            // Act
            var exception = Record.Exception(() => new ID(emptyGuid));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<EmptyIDException>();
        }

        [Fact]
        public async Task Create_ID_With_Valid_Guid_Should_Return_ID()
        {
            // Arrange
            var guid = Guid.NewGuid();

            // Act
            var id = new ID(guid);

            // Assert
            id.ShouldNotBeNull();
            id.Value.ShouldBe(guid);
        }
    }
}