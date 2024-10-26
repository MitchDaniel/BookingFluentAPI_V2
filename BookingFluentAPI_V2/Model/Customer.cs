using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFluentAPI_V2.Model
{
    public class Customer
    {
        public long Id { get; set; }

        public required string Number { get; set; }

        public bool IsAvaliable { get; set; }

        public ICollection<Booking> Bookings { get; set; } = [];

        public long RoomMaintenanceId {  get; set; }

        public RoomMaintenance? RoomMaintenances { get; set; }
    }
}
