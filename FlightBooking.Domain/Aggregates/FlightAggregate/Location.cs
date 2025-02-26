using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightAggregate
{
    public class Location: ValueObject
    {
        public string City { get; private set; }
        public string Code { get; private set; }

        public Location(string city, string code)
        {
            City = city;
            Code = code;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new object[] { City, Code };
        }
    }
}