using FinanceTracker.Domain;
using FinanceTracker.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.Api;

public class OperationService : IOperationService
{
    private readonly ApplicationDbContext _context;

    public OperationService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Operation>> GetAllOperationsAsync()
    {
        return await _context.Operations.ToListAsync();
    }

    public async Task<Operation> CreateOperationAsync(Operation operation)
    {
        _context.Operations.Add(operation);

        var account = await _context.Accounts.FindAsync(operation.AccountId);
        if (account != null)
        {
            if (operation.Type == "Income")
                account.Balance += operation.Amount;
            else if (operation.Type == "Expense")
                account.Balance -= operation.Amount;
        }

        await _context.SaveChangesAsync();
        return operation;
    }
}