namespace FlightBooking.Domain.Aggregates.BookingRequestAggregate.Exceptions
{
    public class InvalidFlightConfirmationDomainException: Exception
    {
        public InvalidFlightConfirmationDomainException()
        {
            
        }
        public InvalidFlightConfirmationDomainException(string message): base(message)
        {
            
        }
        public InvalidFlightConfirmationDomainException(string message, Exception innerException): base(message, innerException)
        {
            
        }
    }
}