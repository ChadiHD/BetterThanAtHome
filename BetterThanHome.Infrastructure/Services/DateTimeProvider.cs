using BetterThanHome.Application.Common.Interfaces.Services;

namespace BetterThanHome.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
