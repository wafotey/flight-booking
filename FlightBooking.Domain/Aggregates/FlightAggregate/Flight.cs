using FlightBooking.Domain.Aggregates.FlightAggregate.Events;
using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightAggregate
{
    public class Flight : Entity<FlightId>, IAggregateRoot
    {
        public string FlightNumber { get; private set; }
        public string FlightName { get; private set; }
        public FlightReferenceId FlightReferenceId { get; private set; }
        public FlightRoute FlightRoute { get; private set; }
        public DateTime DepartureTime { get; private set; }
        public DateTime ArrivalTime { get; private set; }
        public Capacity Capacity { get; private set; }
        public FlightStatus FlightStatus { get; private set; }
        public Onboarding Onboarding { get; private set; }

        public Flight(
            string flightNumber, 
            string flightName, 
            FlightReferenceId flightReferenceId,
            FlightRoute flightRoute, 
            DateTime departureTime, 
            DateTime arrivalTime, 
            Capacity capacity, 
            FlightStatus flightStatus, 
            Onboarding onboarding)
        {
            Id = new FlightId(Guid.NewGuid());
            FlightNumber = flightNumber;
            FlightName = flightName;
            FlightReferenceId = flightReferenceId;
            FlightRoute = flightRoute;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Capacity = capacity;
            FlightStatus = flightStatus;
            Onboarding = onboarding;
        }

           public void DelayFlight(TimeSpan delayDuration)
        {
            DepartureTime = DepartureTime.Add(delayDuration);
            ArrivalTime = ArrivalTime.Add(delayDuration);
            AddDomainEvent(new FlightDelayedDomainEvent(Id, delayDuration));
        }

        public void CancelFlight()
        {
            if (FlightStatus == FlightStatus.Cancelled)
            {
                throw new InvalidOperationException("Flight is already cancelled.");
            }

            FlightStatus = FlightStatus.Cancelled;
            AddDomainEvent(new FlightCancelledDomainEvent(Id));
        }

          #pragma warning disable CS8618 // Non-nullable field is uninitialized.
        private Flight() 
        {
        }
        #pragma warning restore CS8618 // Re-enable warning after this class
    }
}