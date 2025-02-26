using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightSeatAggregate
{
    public class FlightSeatId: TypedIdValueBase
    {
        public FlightSeatId(Guid value) : base(value)
        {
        }

    }
}