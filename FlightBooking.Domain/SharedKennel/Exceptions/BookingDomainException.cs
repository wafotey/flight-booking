namespace FlightBooking.Domain.SharedKennel.Exceptions
{
    public class BookingDomainException: Exception
    {
        public BookingDomainException(string message){

        }
        public BookingDomainException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
        public BookingDomainException()
        {
            
        }
    }
}