using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.CustomerAggregate
{
    public class Address: ValueObject
    {
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public Address(string street, string city, string state, string zipCode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new object[] { Street, City, State, ZipCode };
        }
    }
}