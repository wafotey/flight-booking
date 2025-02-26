using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.NoShowPenaltyAggregate
{
    public class NoShowPenaltyId : TypedIdValueBase
    {
        public NoShowPenaltyId(Guid value) : base(value)
        {
        }
    }
}