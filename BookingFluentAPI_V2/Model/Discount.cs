using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFluentAPI_V2.Model
{
    public class Discount
    {
        public long Id { get; set; }

        public required int DiscountPercentage { get; set; }

        public bool IsActive { get; set; }

        public string? Description { get; set; }

        public long BookingId { get; set; }

        public  required Booking Booking { get; set; }
    }
}
