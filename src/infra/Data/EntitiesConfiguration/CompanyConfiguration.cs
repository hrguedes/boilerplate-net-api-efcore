using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntitiesConfiguration;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        #region Core
        builder.ToTable("dbo", "Companies");
        builder.HasKey(k => k.Id);
        builder.Property(p => p.Id).HasColumnName("Id");
        builder.Property(p => p.CreateAt).HasColumnName("CreateAt");
        builder.Property(p => p.RemovedAt).HasColumnName("RemovedAt");
        builder.Property(p => p.UpdateAt).HasColumnName("UpdateAt");
        builder.Property(p => p.Removed).HasColumnName("Removed");
        builder.Property(p => p.UserCreateId).HasColumnName("UserCreateId");
        builder.Property(p => p.userUpdateId).HasColumnName("userUpdateId");
        builder.HasQueryFilter(filtro => filtro.Removed == false);
        #endregion
        
    }
}