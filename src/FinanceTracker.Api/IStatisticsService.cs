namespace FinanceTracker.Api;

public interface IStatisticsService
{
    Task<object> GetStatisticsAsync();
}