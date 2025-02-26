namespace FlightBooking.Domain.Aggregates.BookingRequestAggregate.Exceptions
{
    public class BookingConfirmationExpiredDomainException: Exception
    {
        public BookingConfirmationExpiredDomainException()
        {
            
        }
        public BookingConfirmationExpiredDomainException(string message): base(message)
        {
            
        }
        public BookingConfirmationExpiredDomainException(string message, Exception innerException): base(message, innerException)
        {
            
        }
    }
}