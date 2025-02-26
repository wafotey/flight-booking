using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.BookingAggregate
{
    public class CheckedInStatus: Enumeration
    {
        public static CheckedInStatus CheckedIn = new CheckedInStatus(1, nameof(CheckedIn).ToLowerInvariant());
        public static CheckedInStatus NotCheckedIn = new CheckedInStatus(2, nameof(NotCheckedIn).ToLowerInvariant());
        
        public CheckedInStatus(int id, string name) : base(id, name)
        {
        }
    }
}