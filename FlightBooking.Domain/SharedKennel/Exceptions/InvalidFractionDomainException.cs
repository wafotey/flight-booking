namespace FlightBooking.Domain.SharedKennel.Exceptions
{
    public class InvalidFractionDomainException: Exception
    {
        public InvalidFractionDomainException()
        {
            
        }
        public InvalidFractionDomainException(string message) : base(message)
        {
            
        }
        public InvalidFractionDomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}