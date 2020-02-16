using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chain.Maps
{
    public class UserDeviceMap : IEntityTypeConfiguration<UserDevice>
    {
        public void Configure(EntityTypeBuilder<UserDevice> builder)
        {
            builder.ToTable(TableConstans.TableHeartBeatUserDevice);

            builder.HasKey(bc => new { bc.UserId, bc.DeviceKey });

            builder.Property(p => p.UserId)
            .HasColumnName(TableConstans.ColumnUserId);

            builder.Property(p => p.DeviceKey)
            .HasColumnName(TableConstans.ColumnDeviceKey);

            builder.Property(p => p.OwnerId)
            .HasColumnName(TableConstans.ColumnOwnerId);

            builder.HasOne(bc => bc.User)
            .WithMany(b => b.UserDevices)
            .HasForeignKey(bc => bc.UserId)
            .HasConstraintName(TableConstans.ColumnUserId);

            builder.HasOne(bc => bc.Device)
            .WithMany(c => c.UserDevices)
            .HasForeignKey(bc => bc.DeviceKey)
            .HasConstraintName(TableConstans.ColumnDeviceKey);
        }
    }
}
