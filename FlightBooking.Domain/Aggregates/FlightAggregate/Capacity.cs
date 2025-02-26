using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightAggregate
{
    public class Capacity : ValueObject
    {
        public int AvailableSeatsForEconomy { get; private set; }
        public int AvailableSeatsForBusiness { get; private set; }
        public int AvailableSeatsForFirstClass { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new object[] { AvailableSeatsForEconomy, AvailableSeatsForBusiness, AvailableSeatsForFirstClass };
        }
    }
}