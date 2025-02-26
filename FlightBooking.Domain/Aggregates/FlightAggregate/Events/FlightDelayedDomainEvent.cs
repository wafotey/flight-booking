using MediatR;

namespace FlightBooking.Domain.Aggregates.FlightAggregate.Events
{
    public class FlightDelayedDomainEvent : INotification
    {
        private FlightId id;
        private TimeSpan delayDuration;

        public FlightDelayedDomainEvent(FlightId id, TimeSpan delayDuration)
        {
            this.id = id;
            this.delayDuration = delayDuration;
        }
    }
}