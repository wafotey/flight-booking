using FlightBooking.Domain.Aggregates.BookingAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class BookingStatusEntityTypeConfigurtion : IEntityTypeConfiguration<BookingStatus>
    {
        public void Configure(EntityTypeBuilder<BookingStatus> builder)
        {
             builder.Property(f => f.Id)
                .HasDefaultValue(1)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(f => f.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}