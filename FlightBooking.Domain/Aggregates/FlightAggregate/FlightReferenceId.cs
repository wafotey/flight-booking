using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightAggregate
{
    public class FlightReferenceId : TypedIdValueBase
    {
        public FlightReferenceId(Guid value) : base(value)
        {
        }
    }
}