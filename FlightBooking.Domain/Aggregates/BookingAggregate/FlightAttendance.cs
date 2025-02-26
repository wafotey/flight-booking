namespace FlightBooking.Domain.Aggregates.BookingAggregate
{
    public class FlightAttendance
    {
        public CheckedInStatus CheckedInStatus { get; private set; }
        public DateTime CheckInTime { get; private set; }
    }
}