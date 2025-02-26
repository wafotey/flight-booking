using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.CustomerAggregate
{
    public class CustomerId : TypedIdValueBase
    {
        public CustomerId(Guid value) : base(value)
        {
        }

      
    }
}