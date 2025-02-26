namespace FlightBooking.Domain.Aggregates.BookingAggregate.Exceptions
{
    public class VisaExpiredDomainException: Exception
    {
        public VisaExpiredDomainException()
        {
        }
        public VisaExpiredDomainException(string message) : base(message)
        {
        }
        public VisaExpiredDomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}