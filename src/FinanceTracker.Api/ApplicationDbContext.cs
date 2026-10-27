using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<FinanceTracker.Domain.Account> Accounts { get; set; }
}
