namespace FlightBooking.Domain.Aggregates.BookingAggregate.Exceptions
{
    public class PassportExpiredDomainException: Exception
    {
        public PassportExpiredDomainException()
        {
            
        }
        public PassportExpiredDomainException(string message): base(message)
        {
            
        }
        public PassportExpiredDomainException(string message, Exception innerException): base(message, innerException)
        {
            
        }
    }
}