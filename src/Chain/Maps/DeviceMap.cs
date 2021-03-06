﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain.Maps
{

    public class DeviceMap : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.ToTable(TableConstans.TableHeartBeatDevice);

            builder.HasKey(p => p.DeviceKey);

            builder.Property(p => p.DeviceKey)
             .HasColumnName(TableConstans.ColumnDeviceKey)
             .HasMaxLength(36);

            builder.Property(p => p.Ip)
                .HasColumnName(TableConstans.ColumnIp);

            builder.Property(p => p.Time)
                .HasColumnName(TableConstans.ColumnTime);

            builder.Property(p => p.Version)
                .HasColumnName(TableConstans.ColumnVersion);

            builder.Property(p => p.PersonCount)
                .HasColumnName(TableConstans.ColumnPersonCount);

            builder.Property(p => p.FaceCount)
                .HasColumnName(TableConstans.ColumnFaceCount);

            builder.Property(p => p.Status)
             .HasColumnName(TableConstans.ColumnStatus)
             .IsRequired();

        }
    }
}
