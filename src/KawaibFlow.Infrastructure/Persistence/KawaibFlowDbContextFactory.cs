using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace KawaibFlow.Infrastructure.Persistence;

public sealed class KawaibFlowDbContextFactory
    : IDesignTimeDbContextFactory<KawaibFlowDbContext>
{
    public KawaibFlowDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<KawaibFlowDbContext>();
        optionsBuilder.UseSqlite("Data Source=kawaibflow.db");

        return new KawaibFlowDbContext(optionsBuilder.Options);
    }
}
