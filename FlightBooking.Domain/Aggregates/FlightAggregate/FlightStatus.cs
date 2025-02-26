using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightAggregate
{
    public class FlightStatus : Enumeration
    {
        public static FlightStatus Scheduled = new FlightStatus(1, nameof(Scheduled));
        public static FlightStatus Active = new FlightStatus(2, nameof(Active));
        public static FlightStatus Cancelled = new FlightStatus(3, nameof(Cancelled));
        public static FlightStatus Delayed = new FlightStatus(4, nameof(Delayed));
        public static FlightStatus Arrived = new FlightStatus(5, nameof(Arrived));


        public FlightStatus(int id, string name) : base(id, name)
        {
        }
    }
}