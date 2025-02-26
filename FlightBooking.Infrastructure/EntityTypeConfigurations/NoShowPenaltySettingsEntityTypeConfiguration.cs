using FlightBooking.Domain.Aggregates.NoShowPenaltySettingsAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class NoShowPenaltySettingsEntityTypeConfiguration : IEntityTypeConfiguration<NoShowPenaltySettings>
    {
        public void Configure(EntityTypeBuilder<NoShowPenaltySettings> builder)
        {
            builder.HasKey(e => e.Id);

            builder.OwnsOne(e => e.EconomyClassPenaltyPercentage, economyClassPenaltyPercentage =>
          {
              economyClassPenaltyPercentage.Property(p => p.Value).HasColumnName(
                  nameof(NoShowPenaltySettings.EconomyClassPenaltyPercentage));
          });

            builder.OwnsOne(e => e.BusinessClassPenaltyPercentage, businessClassPenaltyPercentage =>
              {
                  businessClassPenaltyPercentage.Property(p => p.Value).HasColumnName(
                      nameof(NoShowPenaltySettings.BusinessClassPenaltyPercentage));
              });

            builder.OwnsOne(e => e.FirstClassPenaltyPercentage, firstClassPenaltyPercentage =>
            {
                firstClassPenaltyPercentage.Property(p => p.Value).HasColumnName(
                    nameof(NoShowPenaltySettings.FirstClassPenaltyPercentage));
            });


            builder.OwnsOne(e => e.PeakSeasonPenaltyPercentage, peakSeasonPenaltyPercentage =>
                {
                    peakSeasonPenaltyPercentage.Property(p => p.Value).HasColumnName(
                        nameof(NoShowPenaltySettings.PeakSeasonPenaltyPercentage));
                });


            builder.OwnsOne(e => e.FrequentFlyersPenaltyPercentage, frequentFlyersPenaltyPercentage =>
           {
               frequentFlyersPenaltyPercentage.Property(p => p.Value).HasColumnName(
                   nameof(NoShowPenaltySettings.FrequentFlyersPenaltyPercentage));
           });

            builder.OwnsOne(e => e.NonFrequentFlyersPenaltyPercentage, nonFrequentFlyersPenaltyPercentage =>
           {
               nonFrequentFlyersPenaltyPercentage.Property(p => p.Value).HasColumnName(
                   nameof(NoShowPenaltySettings.NonFrequentFlyersPenaltyPercentage));
           });

        }
    }
}