using FlightBooking.Domain.Aggregates.BookingAggregate;
using FlightBooking.Domain.Aggregates.NoShowPenaltyAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class NoShowPenaltyEntityTypeConfiguration : IEntityTypeConfiguration<NoShowPenalty>
    {
        public void Configure(EntityTypeBuilder<NoShowPenalty> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne<Booking>()
             .WithMany()
             .HasForeignKey(b => b.BookingId);

            builder.OwnsOne(e => e.Percentage, percentage =>
            {
                percentage.Property(p => p.Value)
                .HasColumnName(nameof(NoShowPenalty.Percentage));
            });

            builder.OwnsOne(e => e.CalculatedPenalty, calculatedPenalty =>
            {
                calculatedPenalty.Property(p => p.Amount)
                .HasColumnName(nameof(NoShowPenalty.CalculatedPenalty));
            });

            builder.HasOne(e => e.FlyingStatus)
            .WithMany();

            builder.HasOne(e => e.Season)
            .WithMany();
        }
    }
}