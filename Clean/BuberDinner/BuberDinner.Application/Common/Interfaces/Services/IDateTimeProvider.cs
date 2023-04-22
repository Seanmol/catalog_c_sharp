namespace BuberDinner.Application.Common.Interfaces.Services
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow => DateTime.UtcNow;
    }
}