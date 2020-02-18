using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chain.Maps
{
    public class TaskMap : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable(TableConstans.TableHeartBeatTask);

            builder.Property(p => p.TaskNo)
                .HasColumnName(TableConstans.ColumnTaskNo);

            builder.Property(p => p.InterfaceName)
               .HasColumnName(TableConstans.ColumnInterfaceName);

            builder.HasKey(p => p.TaskNo);

            builder.Property(p => p.Command)
                .HasColumnName(TableConstans.ColumnCommand);

            builder.Property(p => p.Created)
                .HasColumnName(TableConstans.ColumnCreated);

            builder.Property(p => p.Status)
             .HasColumnName(TableConstans.ColumnStatus)
             .IsRequired();

            builder.Property(p => p.DeviceKey)
              .HasColumnName(TableConstans.ColumnDeviceKey)
              .HasMaxLength(36);

            builder.HasOne(d => d.Device)
                .WithMany(p => p.Tasks)
                .HasForeignKey(d => d.DeviceKey);

            builder.Property(p => p.CompanyId)
           .HasColumnName(TableConstans.ColumnCompanyId);

        }
    }
}
