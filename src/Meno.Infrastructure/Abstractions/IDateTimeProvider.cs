namespace Meno.Infrastructure.Abstractions
{
    public interface IDateTimeProvider
    {
        public Task<DateTime> GetNowAsync();
    }
}