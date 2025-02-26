using FlightBooking.Domain.SharedKennel.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class FlyingStatusEntityTypeConfiguration: IEntityTypeConfiguration<FlyingStatus>
    {
        public void Configure(EntityTypeBuilder<FlyingStatus> builder)
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