using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFluentAPI_V2.Model
{
    public class Booking
    {
        public long Id { get; set; }

        public required DateTime CheckInDate { get; set; }

        public required DateTime CheckOutDate { get; set; }

        public long CustomerId { get; set; }

        public required Customer Customer { get; set; }

        public long RoomId {  get; set; }

        public required Customer Room { get; set; }

        public required long DiscountId { get; set; }

        public ICollection<Discount> Discounts { get; set; } = [];

        public ICollection<Payment> Payments { get; set; } = [];
    }
}
