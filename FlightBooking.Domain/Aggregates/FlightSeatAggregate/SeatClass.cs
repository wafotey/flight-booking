using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightSeatAggregate
{
    public class SeatClass : Enumeration
    {
        public static SeatClass Economy = new SeatClass(1, nameof(Economy).ToLowerInvariant());
        public static SeatClass Business = new SeatClass(2, nameof(Business).ToLowerInvariant());
        public static SeatClass FirstClass = new SeatClass(3, nameof(FirstClass).ToLowerInvariant());
        public SeatClass(int id, string name) : base(id, name)
        {
        }
    }
}