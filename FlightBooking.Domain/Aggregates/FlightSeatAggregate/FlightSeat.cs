using FlightBooking.Domain.Aggregates.FlightAggregate;
using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightSeatAggregate
{
    public class FlightSeat : Entity<FlightSeatId>, IAggregateRoot
    {
        public FlightId FlightId { get; private set; }
        public string SeatNumber { get; private set; }
        public SeatState SeatState { get; private set; }
        public SeatClass SeatClass { get; private set; }

        public FlightSeat(FlightId flightId, string seatNumber,SeatClass seatClass)
        {
            FlightId = flightId;
            SeatNumber = seatNumber;
            SeatClass = seatClass;
            SeatState = SeatState.Available;
        }

        public void BookSeat()
        {
            SeatState = SeatState.Book();
        }

        public void CancelBooking()
        {
            SeatState = SeatState.CancelBooking();
        }

        public void BlockSeat()
        {
            SeatState = SeatState.Block();
        }

        public void UnblockSeat()
        {
            SeatState = SeatState.Unblock();
        }

        public bool IsAvailable()
        {
            return SeatState == SeatState.Available;
        }

          #pragma warning disable CS8618 // Non-nullable field is uninitialized.
        private FlightSeat() 
        {
        }
        #pragma warning restore CS8618 // Re-enable warning after this class
    }
}