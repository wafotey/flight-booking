using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.ValueObjects;

namespace FlightBooking.Domain.Aggregates.FlightCancellationPenaltySettingsAggregate
{
    public class FlightCancellationPenaltySettings: Entity<FlightCancellationPenaltySettingsId>, IAggregateRoot
    {
        public Percentage EconomyClassPenaltyPercentage { get; private set; }
        public Percentage BusinessClassPenaltyPercentage { get; private set; }
        public Percentage FirstClassPenaltyPercentage { get; private set; }
        public FlightCancellationPenaltySettings(Percentage economyClassPenaltyPercentage, Percentage businessClassPenaltyPercentage, Percentage firstClassPenaltyPercentage)
        {
            this.EconomyClassPenaltyPercentage = economyClassPenaltyPercentage;
            this.BusinessClassPenaltyPercentage = businessClassPenaltyPercentage;
            this.FirstClassPenaltyPercentage = firstClassPenaltyPercentage;
        }

          #pragma warning disable CS8618 // Non-nullable field is uninitialized.
        private FlightCancellationPenaltySettings() 
        {
        }
        #pragma warning restore CS8618 // Re-enable warning after this class
    }
}