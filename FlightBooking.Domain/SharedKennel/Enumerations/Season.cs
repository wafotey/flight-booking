namespace FlightBooking.Domain.SharedKennel.Enumerations
{
    public class Season : Enumeration
    {
        public static Season PeakSeason = new Season(1, nameof(PeakSeason));
        public static Season NotPeakSeason = new Season(2, nameof(NotPeakSeason));
        public Season(int id, string name) : base(id, name)
        {
        }
    }
}