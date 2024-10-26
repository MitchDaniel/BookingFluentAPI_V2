using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFluentAPI_V2.Model
{
    public class RoomMaintenance
    {
        public long Id { get; set; }

        public required DateTime StartMaintenance { get; set; }

        public DateTime? EndMaintenance { get; set; }

        public string? Description { get; set; }

        public long RoomId { get; set; }

        public required Room Room { get; set; }
    }
}
