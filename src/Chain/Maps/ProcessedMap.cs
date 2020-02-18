using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chain.Maps
{

    public class ProcessedMap : IEntityTypeConfiguration<Processed>
    {
        public void Configure(EntityTypeBuilder<Processed> builder)
        {
            builder.ToTable(TableConstans.TableHeartBeatProcessed);

            builder.HasKey(p => p.TaskNo);

            builder.Property(p => p.TaskNo)
                .HasColumnName(TableConstans.ColumnTaskNo);

            builder.Property(p => p.DeviceKey)
               .HasColumnName(TableConstans.ColumnDeviceKey)
               .HasMaxLength(36)
               .IsRequired();

            builder.Property(p => p.Msg)
              .HasColumnName(TableConstans.ColumnMsg);

            builder.Property(p => p.Result)
             .HasColumnName(TableConstans.ColumnResult);

            builder.Property(p => p.Success)
             .HasColumnName(TableConstans.ColumnSuccess);

            builder.Property(p => p.Data)
             .HasColumnName(TableConstans.ColumnData);

            builder.Property(p => p.Created)
                .HasColumnName(TableConstans.ColumnCreated);

            builder.Property(p => p.InterfaceName)
              .HasColumnName(TableConstans.ColumnInterfaceName);

            builder.Property(p => p.Command)
             .HasColumnName(TableConstans.ColumnCommand);

            builder.Property(p => p.CompanyId)
             .HasColumnName(TableConstans.ColumnCompanyId);

            builder.Property(p => p.Received)
             .HasColumnName(TableConstans.ColumnReceived);

        }
    }
}
