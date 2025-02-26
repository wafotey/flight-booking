using FlightBooking.Domain.Aggregates.FlightCancellationPenaltySettingsAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class FlightCancellationPenaltySettingsEntityTypeConfiguration : IEntityTypeConfiguration<FlightCancellationPenaltySettings>
    {
        public void Configure(EntityTypeBuilder<FlightCancellationPenaltySettings> builder)
        {
            builder.HasKey(e => e.Id);

            builder.OwnsOne(e => e.EconomyClassPenaltyPercentage, economyClassPenaltyPercentage =>
            {
                economyClassPenaltyPercentage.Property(p => p.Value).HasColumnName(
                    nameof(FlightCancellationPenaltySettings.EconomyClassPenaltyPercentage));
            });
             builder.OwnsOne(e => e.BusinessClassPenaltyPercentage, businessClassPenaltyPercentage =>
            {
                businessClassPenaltyPercentage.Property(p => p.Value).HasColumnName(
                    nameof(FlightCancellationPenaltySettings.BusinessClassPenaltyPercentage));
            });


             builder.OwnsOne(e => e.FirstClassPenaltyPercentage, firstClassPenaltyPercentage =>
            {
                firstClassPenaltyPercentage.Property(p => p.Value).HasColumnName(
                    nameof(FlightCancellationPenaltySettings.FirstClassPenaltyPercentage));
            });
        }
    }
}