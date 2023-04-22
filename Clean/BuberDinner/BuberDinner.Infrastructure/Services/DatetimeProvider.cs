using BuberDinner.Application.Common.Interfaces.Services;

namespace BuberDinner.Infrastructure.Services
{
    public class DatetimeProvider : IDateTimeProvider
    {
        public DateTimeOffset Now => DateTime.UtcNow;
    }
}