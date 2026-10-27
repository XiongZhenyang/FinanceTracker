using FinanceTracker.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceTracker.Api;

public interface IAccountService
{
    Task<List<Account>> GetAllAccountsAsync();
    Task<Account> CreateAccountAsync(Account account);
}
