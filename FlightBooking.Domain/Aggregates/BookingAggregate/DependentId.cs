using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.BookingAggregate
{
    public class DependentId : TypedIdValueBase
    {
        public DependentId(Guid value) : base(value)
        {
        }
    }
}