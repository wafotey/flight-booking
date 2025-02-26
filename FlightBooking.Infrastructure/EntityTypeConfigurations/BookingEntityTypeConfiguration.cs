using FlightBooking.Domain.Aggregates.BookingAggregate;
using FlightBooking.Domain.Aggregates.CustomerAggregate;
using FlightBooking.Domain.Aggregates.FlightAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class BookingEntityTypeConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne<Customer>()
                .WithMany()
                .HasForeignKey(c => c.CustomerId);

           builder.HasOne<Passport>()
                .WithOne()
                .HasForeignKey(nameof(Booking.Passport));

            builder.HasOne<Flight>()
                .WithMany()
                .HasForeignKey(f => f.FlightId);

            builder.HasOne(e => e.BookingStatus)
                .WithMany();

            builder.OwnsOne(e => e.Visa, visa =>
            {
                visa.Property(v => v.VisaNumber)
                    .HasColumnName(nameof(Visa.VisaNumber))
                    .HasMaxLength(10)
                    .IsRequired();

                visa.Property(v => v.ExpiryDate)
                    .HasColumnName(nameof(Visa.ExpiryDate))
                    .HasMaxLength(10)
                    .IsRequired();

                visa.Property(v => v.IssueDate)
                    .HasColumnName(nameof(Visa.IssueDate))
                    .HasMaxLength(10)
                    .IsRequired();

                visa.HasOne(v => v.VisaType)
                    .WithMany();

                visa.HasOne(v => v.IssuingCountry)
                    .WithMany();
            });
        }
    }
}