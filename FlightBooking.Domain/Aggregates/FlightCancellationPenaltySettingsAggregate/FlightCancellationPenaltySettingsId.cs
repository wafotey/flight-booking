using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightCancellationPenaltySettingsAggregate
{
    public class FlightCancellationPenaltySettingsId : TypedIdValueBase
    {
        public FlightCancellationPenaltySettingsId(Guid value) : base(value)
        {
        }
    }
}