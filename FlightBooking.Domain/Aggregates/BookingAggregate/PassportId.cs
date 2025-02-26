using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.BookingAggregate
{
    public class PassportId: TypedIdValueBase
    {
        public PassportId(Guid value) : base(value)
        {}
    }
}