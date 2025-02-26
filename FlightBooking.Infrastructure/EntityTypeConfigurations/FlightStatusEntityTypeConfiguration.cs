using FlightBooking.Domain.Aggregates.FlightAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class FlightStatusEntityTypeConfiguration : IEntityTypeConfiguration<FlightStatus>
    {
        public void Configure(EntityTypeBuilder<FlightStatus> builder)
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