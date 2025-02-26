namespace FlightBooking.Domain.SharedKennel.Exceptions
{
    public class InvalidPercentageDomainException: Exception
    {
        public InvalidPercentageDomainException()
        {
            
        }
        public InvalidPercentageDomainException(string message): base(message)
        {
            
        }
        public InvalidPercentageDomainException(string message, Exception innerException): base(message, innerException)
        {
    }
    }
}