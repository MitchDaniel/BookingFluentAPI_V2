using BookingFluentAPI_V2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFluentAPI_V2.Infrastructure.EntityTypeConfiguration
{
    internal class RoomMaintenanceEntityTypeConfiguration : IEntityTypeConfiguration<RoomMaintenance>
    {
        public void Configure(EntityTypeBuilder<RoomMaintenance> builder)
        {
            builder.HasKey(rm => rm.Id);
            builder.Property(rm => rm.Id).ValueGeneratedOnAdd();

            builder
                .HasOne(r => r.Room)
                .WithOne(rm => rm.RoomMaintenance)
                .HasForeignKey<RoomMaintenance>(rm => rm.RoomId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
