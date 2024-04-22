using Meno.Infrastructure.Abstractions;

namespace Meno.Application.Implementations
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public Task<DateTime> GetNowAsync() => Task.FromResult(DateTime.Now);
    }
}