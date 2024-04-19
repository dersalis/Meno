using Meno.Core.Exceptions;
using Meno.Core.ValueObjects;
using Shouldly;

namespace Meno.Tests.Unit.ValueObjects
{
    public class TimeStampTests
    {
        [Fact]
        public async Task Create_TimeStamp_With_Empty_DateTime_Should_Throw_EmptyTimeStampException()
        {
            // Arrange
            var emptyDateTime = DateTime.MinValue;

            // Act
            var exception = Record.Exception(() => new TimeStamp(emptyDateTime));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<SmallerTimeStampException>();
        }

        [Fact]
        public async Task Create_TimeStamp_With_Valid_DateTime_Should_Return_TimeStamp()
        {
            // Arrange
            var dateTime = DateTime.Now;

            // Act
            var timeStamp = new TimeStamp(dateTime);

            // Assert
            timeStamp.ShouldNotBeNull();
            timeStamp.Value.ShouldBe(dateTime);
        }

        [Fact]
        public async Task Implicit_Conversion_From_TimeStamp_To_DateTime_Should_Return_DateTime()
        {
            // Arrange
            var dateTime = DateTime.Now;
            var timeStamp = new TimeStamp(dateTime);

            // Act
            DateTime timeStampDateTime = timeStamp;

            // Assert
            timeStampDateTime.ShouldBe(dateTime);
        }
    }
}