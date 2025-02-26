namespace FlightBooking.Domain.SharedKennel.Enumerations
{
    public class Currency : Enumeration
    {
        public static Currency Euro = new Currency(1, nameof(Euro));
        public static Currency USD = new Currency(2, nameof(USD));
        public static Currency BritishPound = new Currency(3, nameof(BritishPound));
        public Currency(int id, string name) : base(id, name)
        {
        }
    }
}