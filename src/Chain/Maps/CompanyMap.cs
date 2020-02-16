using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chain.Maps
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable(TableConstans.TableHeartBeatCompany);

            builder.HasKey(p => p.CompanyId);

            builder.Property(p => p.CompanyId)
                .HasColumnName(TableConstans.ColumnCompanyId);

            builder.Property(p => p.CompanyKey)
               .HasColumnName(TableConstans.ColumnCompanyKey)
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(p => p.Name)
               .HasColumnName(TableConstans.ColumnName)
               .HasMaxLength(200)
               .IsRequired();

            builder.Property(p => p.Status)
               .HasColumnName(TableConstans.ColumnStatus);
        }
    }
}