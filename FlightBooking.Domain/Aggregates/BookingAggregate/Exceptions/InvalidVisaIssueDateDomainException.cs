namespace FlightBooking.Domain.Aggregates.BookingAggregate.Exceptions
{
    public class InvalidVisaIssueDateDomainException: Exception
    {
        public InvalidVisaIssueDateDomainException()
        {
        }
        public InvalidVisaIssueDateDomainException(string message) : base(message)
        {
        }
        public InvalidVisaIssueDateDomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}