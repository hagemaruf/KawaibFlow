using Microsoft.EntityFrameworkCore;

namespace KawaibFlow.Infrastructure.Persistence;

public sealed class KawaibFlowDbContext : DbContext
{
    public KawaibFlowDbContext(DbContextOptions<KawaibFlowDbContext> options)
        : base(options)
    {
    }
}
