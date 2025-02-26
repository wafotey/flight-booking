namespace FlightBooking.Domain.Aggregates.BookingRequestAggregate.Exceptions
{
    public class InvalidFlightCancellationDomainException: Exception
    {
        public InvalidFlightCancellationDomainException()
        {
            
        }
        public InvalidFlightCancellationDomainException(string message): base(message)
        {
            
        }
        public InvalidFlightCancellationDomainException(string message, Exception innerException): base(message, innerException)
        {
            
        }
    }
}