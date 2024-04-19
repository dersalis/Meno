using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class ActivityTests
    {
        [Fact]
        public async Task Create_Activity_With_True_Should_Return_Activity()
        {
            // Arrange
            var value = true;

            // Act
            var activity = new Activity(value);

            // Assert
            activity.ShouldNotBeNull();
            activity.Value.ShouldBe(value);
        }

        [Fact]
        public async Task Create_Activity_With_False_Should_Return_Activity()
        {
            // Arrange
            var value = false;

            // Act
            var activity = new Activity(value);

            // Assert
            activity.ShouldNotBeNull();
            activity.Value.ShouldBe(value);
        }
    }
}