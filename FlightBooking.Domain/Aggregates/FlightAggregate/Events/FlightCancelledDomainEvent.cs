using MediatR;

namespace FlightBooking.Domain.Aggregates.FlightAggregate.Events
{
    public class FlightCancelledDomainEvent: INotification
    {
        public FlightId FlightId { get;private set; }
        public FlightCancelledDomainEvent(FlightId flightId)
        {
            FlightId = flightId;
        }
    }
}