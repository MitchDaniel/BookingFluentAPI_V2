using BookingFluentAPI_V2.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookingFluentAPI_V2.Infrastructure.EntityTypeConfiguration
{
    internal class RoomEntityTypeConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();

            builder
               .HasOne(r => r.RoomMaintenance)
               .WithOne(rm => rm.Room)
               .HasForeignKey<Room>(r => r.RoomMaintenanceId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
