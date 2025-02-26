using FlightBooking.Domain.Aggregates;
using FlightBooking.Domain.Aggregates.CustomerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBooking.Infrastructure.EntityTypeConfigurations
{
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.Id);

            builder.OwnsOne(e => e.Address, address =>
            {
                address.Property(a => a.Street).HasColumnName(nameof(Address.Street));
                address.Property(a => a.City).HasColumnName(nameof(Address.City));
                address.Property(a => a.State).HasColumnName(nameof(Address.State));
                address.Property(a => a.ZipCode).HasColumnName(nameof(Address.ZipCode));
            });
        }
    }
}