using FinanceTracker.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.Api;

public class StatisticsService : IStatisticsService
{
    private readonly ApplicationDbContext _context;

    public StatisticsService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<object> GetStatisticsAsync()
    {
        var totalIncome = await _context.Operations
            .Where(o => o.Type == "Income")
            .SumAsync(o => o.Amount);

        var totalExpense = await _context.Operations
            .Where(o => o.Type == "Expense")
            .SumAsync(o => o.Amount);

        return new
        {
            TotalIncome = totalIncome,
            TotalExpense = totalExpense,
            NetBalance = totalIncome - totalExpense
        };
    }
}