using FinanceTracker.Domain;
using FinanceTracker.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceTracker.Api;

public class AccountService : IAccountService
{
    private readonly ApplicationDbContext _context;
    public AccountService(ApplicationDbContext context) { _context = context; }
    public async Task<List<Account>> GetAllAccountsAsync() { return await _context.Accounts.ToListAsync(); }
    public async Task<Account> CreateAccountAsync(Account account) { _context.Accounts.Add(account); await _context.SaveChangesAsync(); return account; }
}
