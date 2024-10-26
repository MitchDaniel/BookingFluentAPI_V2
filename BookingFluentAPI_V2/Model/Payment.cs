using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFluentAPI_V2.Model
{
    public class Payment
    {
        public long Id { get; set; }

        public required DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }

        public required string PaymentMethod { get; set; }

        public long BookingId { get; set; }

        public required Booking Bookings { get; set; }
    }
}
