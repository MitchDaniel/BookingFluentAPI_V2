using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFluentAPI_V2.Model
{
    public class Room
    {
        public long Id { get; set; }

        public required string Name { get; set; }

        public required string Surname { get; set; }

        public string? Email { get; set; }

        public long RoomMaintenanceId { get; set; }

        public required RoomMaintenance RoomMaintenance { get; set; }

        public ICollection<Booking> Bookings { get; set; } = [];
    }
}
