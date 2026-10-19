using Microsoft.EntityFrameworkCore;
using FinanceTracker.Domain;

namespace FinanceTracker.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }
}