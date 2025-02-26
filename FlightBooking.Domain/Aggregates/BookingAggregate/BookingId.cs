using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.BookingAggregate
{
    public class BookingId : TypedIdValueBase
    {
        public BookingId(Guid value) : base(value)
        {
        } 
    
    }
}