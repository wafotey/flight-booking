namespace FlightBooking.Domain.Aggregates.BookingAggregate.Exceptions
{
    public class InvalidPassportIssueDateDomainException: Exception
    {
        public InvalidPassportIssueDateDomainException()
        {
            
        }
        public InvalidPassportIssueDateDomainException(string message): base(message)
        {
            
        }
        public InvalidPassportIssueDateDomainException(string message, Exception innerException): base(message, innerException)
        {
            
        }
    }
}