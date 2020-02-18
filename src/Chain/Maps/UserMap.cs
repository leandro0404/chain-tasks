using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chain.Maps
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(TableConstans.TableHeartBeatUser);

            builder.Property(p => p.UserId)
                .HasColumnName(TableConstans.ColumnUserId);

            builder.HasKey(p => p.UserId);

            builder.Property(p => p.Name)
               .HasColumnName(TableConstans.ColumnName)
               .HasMaxLength(200)
               .IsRequired();

            builder.Property(p => p.Status)
              .HasColumnName(TableConstans.ColumnStatus)
              .IsRequired();

            builder.Property(p => p.CompanyId)
                .HasColumnName(TableConstans.ColumnCompanyId);

        }
    }
}
