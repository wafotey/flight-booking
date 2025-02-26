using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.BookingAggregate
{
    public class BookingStatus: Enumeration
    {
        public static BookingStatus Pending = new BookingStatus(1, nameof(Pending).ToLowerInvariant());
        public static BookingStatus Confirmed = new BookingStatus(2, nameof(Confirmed).ToLowerInvariant());
        public static BookingStatus Cancelled = new BookingStatus(3, nameof(Cancelled).ToLowerInvariant());
        public static BookingStatus Expired = new BookingStatus(4, nameof(Expired).ToLowerInvariant());
        public static BookingStatus NoShow = new BookingStatus(5, nameof(NoShow).ToLowerInvariant());

        public BookingStatus(int id, string name) : base(id, name)
        {
        }
    }
}