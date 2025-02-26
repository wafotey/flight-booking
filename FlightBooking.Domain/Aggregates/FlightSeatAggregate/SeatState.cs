using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.FlightSeatAggregate
{
    public class SeatState : Enumeration
    {
        public static SeatState Available = new SeatState(1, nameof(Available).ToLowerInvariant());
        public static SeatState Booked = new SeatState(2, nameof(Booked).ToLowerInvariant());
        public static SeatState Blocked = new SeatState(3, nameof(Blocked).ToLowerInvariant());
        public static SeatState NotAvailable = new SeatState(4, nameof(NotAvailable).ToLowerInvariant());

        public SeatState(int id, string name) : base(id, name)
        {
        }

        public bool CanBook()
        {
            return this == Available;
        }

        public bool CanCancelBooking()
        {
            return this == Booked;
        }

        public bool CanBlock()
        {
            return this == Available;
        }

        public bool CanUnblock()
        {
            return this == Blocked;
        }

        public SeatState Book()
        {
            if (!CanBook())
            {
                throw new InvalidOperationException("Seat cannot be booked.");
            }

            return Booked;
        }

        public SeatState CancelBooking()
        {
            if (!CanCancelBooking())
            {
                throw new InvalidOperationException("Booking cannot be cancelled.");
            }

            return Available;
        }

        public SeatState Block()
        {
            if (!CanBlock())
            {
                throw new InvalidOperationException("Seat cannot be blocked.");
            }

            return Blocked;
        }

        public SeatState Unblock()
        {
            if (!CanUnblock())
            {
                throw new InvalidOperationException("Seat cannot be unblocked.");
            }

            return Available;
        }
    }
}