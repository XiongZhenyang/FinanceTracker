using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FinanceTracker.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        // 这里的密码保持和 appsettings.json 里的一致（123456）
        optionsBuilder.UseNpgsql("Host=localhost;Database=FinanceTracker;Username=postgres;Password=123456");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}