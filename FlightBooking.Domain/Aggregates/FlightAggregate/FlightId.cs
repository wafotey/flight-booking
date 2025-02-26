using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightAggregate
{
    public class FlightId : TypedIdValueBase
    {
        public FlightId(Guid value) : base(value)
        {
        }
    }
}