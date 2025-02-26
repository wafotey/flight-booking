using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightAggregate
{
    public class Onboarding: ValueObject
    {
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }

        public Onboarding(DateTime startAt, DateTime endAt)
        {
            this.StartAt = startAt;
            this.EndAt = endAt;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new object[] { StartAt, EndAt };
        }
    }
}