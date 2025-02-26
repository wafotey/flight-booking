using FlightBooking.Domain.Aggregates.BookingAggregate;
using FlightBooking.Domain.Aggregates.FlightCancellationPenaltyAggregate;
using FlightBooking.Domain.SharedKennel.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class FlightCancellationPenaltyEntityTypeConfiguration : IEntityTypeConfiguration<FlightCancellationPenalty>
    {
        public void Configure(EntityTypeBuilder<FlightCancellationPenalty> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne<Booking>()
             .WithMany()
             .HasForeignKey(b => b.BookingId);

             builder.OwnsOne(e => e.Percentage, percentage =>
            {
                percentage.Property(p => p.Value).HasColumnName(nameof(Percentage));
            });

              builder.OwnsOne(e => e.CalculatedPenalty, calculatedPenalty =>
            {
                calculatedPenalty.Property(s => s.Amount).HasColumnName(nameof(Money.Amount));
                calculatedPenalty.HasOne(v => v.Currency)
                    .WithMany();
            });

        }
    }
}