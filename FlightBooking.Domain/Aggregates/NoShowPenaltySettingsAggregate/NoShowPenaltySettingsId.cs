using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.NoShowPenaltySettingsAggregate
{
    public class NoShowPenaltySettingsId : TypedIdValueBase
    {
        public NoShowPenaltySettingsId(Guid value) : base(value)
        {
        }
    }
}