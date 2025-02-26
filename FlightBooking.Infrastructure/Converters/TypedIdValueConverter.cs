using FlightBooking.Domain.SharedKennel;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlightBooking.Infrastructure.Converters
{
    public class TypedIdValueConverter<TTypedIdValue> : ValueConverter<TTypedIdValue, Guid>
      where TTypedIdValue : TypedIdValueBase
    {
        public TypedIdValueConverter(ConverterMappingHints mappingHints)
            : base(id => id.Value, value => Create(value), mappingHints)
        {
        }

        private static TTypedIdValue Create(Guid id)
        {
            var instance = Activator.CreateInstance(typeof(TTypedIdValue), id) as TTypedIdValue;
            if (instance is null)
            {
                throw new InvalidOperationException($"Failed to create an instance of type {typeof(TTypedIdValue)}");
            }
            return instance;
        }

    }
}