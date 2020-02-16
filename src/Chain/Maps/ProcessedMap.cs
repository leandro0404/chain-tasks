using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chain.Maps
{

    public class ProcessedMap : IEntityTypeConfiguration<Processed>
    {
        public void Configure(EntityTypeBuilder<Processed> builder)
        {
            builder.ToTable(TableConstans.TableHeartBeatProcessed);

            builder.HasKey(bc => new { bc.ProcessedId, bc.TaskNo });

            builder.Property(p => p.ProcessedId)
               .HasColumnName(TableConstans.ColumnProcessedId);

            builder.Property(p => p.TaskNo)
                .HasColumnName(TableConstans.ColumnTaskNo);

            builder.Property(p => p.DeviceKey)
               .HasColumnName(TableConstans.ColumnDeviceKey)
               .HasMaxLength(36)
               .IsRequired();

            builder.Property(p => p.Msg)
              .HasColumnName(TableConstans.ColumnMsg)
              .HasMaxLength(200);

            builder.Property(p => p.Result)
             .HasColumnName(TableConstans.ColumnResult);

            builder.Property(p => p.Success)
             .HasColumnName(TableConstans.ColumnSuccess);

            builder.Property(p => p.Data)
             .HasColumnName(TableConstans.ColumnData);

            builder.Property(p => p.Created)
                .HasColumnName(TableConstans.ColumnCreated);

            builder.Property(p => p.InterfaceName)
              .HasColumnName(TableConstans.ColumnInterfaceName)
              .HasMaxLength(50); 

            builder.Property(p => p.Command)
             .HasColumnName(TableConstans.ColumnCommand);

        }
    }
}
