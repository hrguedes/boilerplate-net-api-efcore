using Data.EntitiesConfiguration;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class AppContextDB : DbContext
{
    public AppContextDB(DbContextOptions<AppContextDB> options)
        : base(options)
    {
    }

    #region Overriden

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyConfiguration).Assembly);
    }

    #endregion

    public DbSet<Company> Companies { get; set; }
}