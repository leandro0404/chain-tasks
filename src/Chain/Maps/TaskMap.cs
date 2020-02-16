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

            builder.HasKey(p => p.TaskNo);

            builder.Property(p => p.InterfaceName)
                .HasColumnName(TableConstans.ColumnInterfaceName);

            builder.Property(p => p.Command)
                .HasColumnName(TableConstans.ColumnCommand);

            builder.Property(p => p.Created)
                .HasColumnName(TableConstans.ColumnCreated);

            builder.Property(p => p.Status)
              .HasColumnName(TableConstans.ColumnStatus)
              .IsRequired();

        }
    }
}
