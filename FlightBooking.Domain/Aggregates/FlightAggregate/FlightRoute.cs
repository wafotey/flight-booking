using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightAggregate
{
    public class FlightRoute: ValueObject
    {
        public Location Origin { get; set; }
        public Location Destination { get; set; }

        public FlightRoute(Location origin, Location destination)
        {
            this.Origin = origin;
            this.Destination = destination;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new object[] { Origin, Destination };
        }

          #pragma warning disable CS8618 // Non-nullable field is uninitialized.
         private FlightRoute() 
        {
        }
        #pragma warning restore CS8618 // Re-enable warning after this class
    }
}