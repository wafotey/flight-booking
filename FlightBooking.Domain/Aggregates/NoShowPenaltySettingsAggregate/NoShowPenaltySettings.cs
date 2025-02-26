using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.ValueObjects;

namespace FlightBooking.Domain.Aggregates.NoShowPenaltySettingsAggregate
{
    public class NoShowPenaltySettings : Entity<NoShowPenaltySettingsId>, IAggregateRoot
    {
        public Percentage EconomyClassPenaltyPercentage { get; private set; }
        public Percentage BusinessClassPenaltyPercentage { get; private set; }
        public Percentage FirstClassPenaltyPercentage { get; private set; }
        public Percentage PeakSeasonPenaltyPercentage { get; private set; }
        public Percentage FrequentFlyersPenaltyPercentage { get; private set; }
        public Percentage NonFrequentFlyersPenaltyPercentage { get; private set; }

        public NoShowPenaltySettings(
            Percentage economyClassPenaltyPercentage,
            Percentage businessClassPenaltyPercentage,
            Percentage firstClassPenaltyPercentage,
            Percentage peakSeasonPenaltyPercentage,
            Percentage frequentFlyersPenaltyPercentage,
            Percentage nonFrequentFlyersPenaltyPercentage)
        {
            this.EconomyClassPenaltyPercentage = economyClassPenaltyPercentage;
            this.BusinessClassPenaltyPercentage = businessClassPenaltyPercentage;
            this.FirstClassPenaltyPercentage = firstClassPenaltyPercentage;
            this.PeakSeasonPenaltyPercentage = peakSeasonPenaltyPercentage;
            this.FrequentFlyersPenaltyPercentage = frequentFlyersPenaltyPercentage;
            this.NonFrequentFlyersPenaltyPercentage = nonFrequentFlyersPenaltyPercentage;
        }

#pragma warning disable CS8618 // Non-nullable field is uninitialized.
        private NoShowPenaltySettings()
        {
        }
#pragma warning restore CS8618 // Re-enable warning after this class
    }
}