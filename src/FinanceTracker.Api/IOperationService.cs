using FinanceTracker.Domain;

namespace FinanceTracker.Api;

public interface IOperationService
{
    Task<List<Operation>> GetAllOperationsAsync();
    Task<Operation> CreateOperationAsync(Operation operation);
}