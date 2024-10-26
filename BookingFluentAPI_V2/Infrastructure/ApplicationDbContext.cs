using BookingFluentAPI_V2.Model;
using Microsoft.EntityFrameworkCore;

namespace BookingFluentAPI_V2.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Discount> Discounts { get; set; }

        public DbSet<Payment> Payments  { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomMaintenance> RoomMaintenances { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
