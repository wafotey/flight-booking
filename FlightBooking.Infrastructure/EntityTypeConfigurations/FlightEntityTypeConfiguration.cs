using FlightBooking.Domain.Aggregates.FlightAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class FlightEntityTypeConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FlightNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.OwnsOne(e => e.FlightRoute, flightRoute =>
            {
                flightRoute.OwnsOne(fr => fr.Origin, origin =>
                {
                    origin.Property(o => o.City)
                        .HasColumnName("OriginCity")
                        .IsRequired();

                    origin.Property(o => o.Code)
                        .HasColumnName("OriginCode")
                        .IsRequired();
                });

                flightRoute.OwnsOne(fr => fr.Destination, destination =>
                {
                    destination.Property(d => d.City)
                        .HasColumnName("DestinationCity")
                        .IsRequired();

                    destination.Property(d => d.Code)
                        .HasColumnName("DestinationCode")
                        .IsRequired();
                });
            });
            builder.OwnsOne(e => e.Capacity, capacity =>
            {
                capacity.Property(c => c.AvailableSeatsForEconomy)
                    .HasColumnName(nameof(Capacity.AvailableSeatsForEconomy))
                    .IsRequired();
                capacity.Property(c => c.AvailableSeatsForBusiness)

               .HasColumnName(nameof(Capacity.AvailableSeatsForBusiness))
               .IsRequired();
                capacity.Property(c => c.AvailableSeatsForFirstClass)
                
               .HasColumnName(nameof(Capacity.AvailableSeatsForFirstClass))
               .IsRequired();
            });
            builder.Property(e => e.DepartureTime)
                .IsRequired();

            builder.Property(e => e.ArrivalTime)
                .IsRequired();

            builder.Property(e => e.FlightReferenceId)
                .IsRequired();

            builder.OwnsOne(e => e.Onboarding, onboarding =>
            {
                onboarding.Property(o => o.StartAt)
                    .HasColumnName("OnboardingStartAt")
                    .IsRequired();

                onboarding.Property(o => o.EndAt)
                    .HasColumnName("OnboardingEndAt")
                    .IsRequired();
            });

            builder.HasOne(e => e.FlightStatus)
            .WithMany();
        }
    }
}