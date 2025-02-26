namespace FlightBooking.Domain.SharedKennel.Enumerations
{
    public class FlyingStatus : Enumeration
    {
        public static FlyingStatus FrequentFlyer = new FlyingStatus(1, nameof(FrequentFlyer)); 
        public static FlyingStatus NoneFrequentFlyer = new FlyingStatus(2, nameof(NoneFrequentFlyer)); 
        public FlyingStatus(int id, string name) : base(id, name)
        {
        }

        public static bool IsFrequentFlyer(FlyingStatus status)
        {
            return status == FrequentFlyer;
        }
    }
}