using FlightBooking.Domain.Aggregates.BookingAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class PassportEntityTypeConfiguration : IEntityTypeConfiguration<Passport>
    {
        public void Configure(EntityTypeBuilder<Passport> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.PassportNumber)
                .HasColumnName(nameof(Passport.PassportNumber))
                .HasMaxLength(10)
                .IsRequired();

           builder.HasOne(v => v.Nationality)
                    .WithMany();

             builder.HasOne(v => v.IssuingCountry)
                    .WithMany();
        }
    }
}