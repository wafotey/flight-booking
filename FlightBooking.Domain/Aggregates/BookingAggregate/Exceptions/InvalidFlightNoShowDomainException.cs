namespace FlightBooking.Domain.Aggregates.BookingRequestAggregate.Exceptions
{
    public class InvalidFlightNoShowDomainException: Exception
    {
        public InvalidFlightNoShowDomainException()
        {
            
        }
        public InvalidFlightNoShowDomainException(string message): base(message)
        {
            
        }
        public InvalidFlightNoShowDomainException(string message, Exception innerException): base(message, innerException)
        {
            
        }
    }
}