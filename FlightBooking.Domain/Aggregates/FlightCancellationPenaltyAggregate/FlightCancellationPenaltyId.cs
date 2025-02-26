using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightCancellationPenaltyAggregate
{
    public class FlightCancellationPenaltyId : TypedIdValueBase
    {
        public FlightCancellationPenaltyId(Guid value) : base(value)
        {
        }
    }
}