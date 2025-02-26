using FlightBooking.Domain.Aggregates.BookingRequestAggregate.Events;
using FlightBooking.Domain.Aggregates.BookingRequestAggregate.Exceptions;
using FlightBooking.Domain.Aggregates.CustomerAggregate;
using FlightBooking.Domain.Aggregates.FlightAggregate;
using FlightBooking.Domain.Aggregates.FlightSeatAggregate;
using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.BookingAggregate
{
    public class Booking : Entity<BookingId>, IAggregateRoot
    {
        public CustomerId CustomerId { get; private set; }
        public FlightSeatId FlightSeatId { get; private set; }
        public FlightId FlightId { get; private set; }
        public DateTime BookingDate { get; private set; }
        public BookingStatus BookingStatus { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public Passport Passport { get; private set; }
        public Visa? Visa { get; private set; }
        private List<Dependent> _dependents ;
        public IReadOnlyCollection<Dependent> Dependents => _dependents.AsReadOnly();

      
        public Booking(
            CustomerId customerId, 
            FlightId flightId, 
            FlightSeatId flightSeatId,
            DateTime bookingDate, 
            DateTime flightDepartureTime,
            List<Dependent> dependents,
            Passport passport,
            Visa? visa = null
            )
        {
            Id = new BookingId(Guid.NewGuid());
            CustomerId = customerId;
            FlightId = flightId;
            FlightSeatId = flightSeatId;
            _dependents = dependents ?? new List<Dependent>();
            Passport = passport;
            Visa = visa;
            BookingStatus = BookingStatus.Pending;
            _dependents = dependents ?? new List<Dependent>();

            if (IsBookingRequestMoreThan48HoursBeforeFlightDeparture(flightDepartureTime))
            {
                ExpirationDate = bookingDate.AddHours(24);
            }
            else
            {
                ExpirationDate = bookingDate.AddHours(6);
            }
        }

        private bool IsBookingRequestMoreThan48HoursBeforeFlightDeparture( DateTime flightDepartureTime)
        {
            return (flightDepartureTime - BookingDate).TotalHours > 48;
        }

        public void Confirm()
        {
            if (BookingStatus != BookingStatus.Pending)
            {
                throw new InvalidFlightConfirmationDomainException("Only pending bookings can be confirmed.");
            }

            if (DateTime.Now > ExpirationDate)
            {
                throw new BookingConfirmationExpiredDomainException("Booking confirmation expired.");
            }

            BookingStatus = BookingStatus.Confirmed;
            AddDomainEvent(new BookingConfirmedDomainEvent());
        }

        public void Cancel()
        {
            if (BookingStatus == BookingStatus.Cancelled)
            {
                throw new InvalidFlightCancellationDomainException("Booking is already cancelled.");
            }

            BookingStatus = BookingStatus.Cancelled;
            AddDomainEvent(new BookingCancelledDomainEvent());
        }

          public void MarkAsNoShow(DateTime flightDepartureTime)
         {
            if (BookingStatus != BookingStatus.Confirmed)
            {
                throw new InvalidFlightNoShowDomainException("Only confirmed bookings can be marked as no-show.");
            }

            if (DateTime.Now < flightDepartureTime)
            {
                throw new InvalidFlightNoShowDomainException("Cannot mark as no-show before the flight departure time.");
            }

            BookingStatus = BookingStatus.NoShow;
            AddDomainEvent(new BookingMarkedAsNoShowDomainEvent());
        }

          public void Expire()
        {
            if (BookingStatus != BookingStatus.Pending)
            {
                throw new InvalidOperationException("Only pending bookings can be expired.");
            }

            if (DateTime.Now <= ExpirationDate)
            {
                throw new InvalidOperationException("Cannot expire booking before the expiration date.");
            }

            BookingStatus = BookingStatus.Expired;
            AddDomainEvent(new BookingExpiredDomainEvent());
        }
        #pragma warning disable CS8618 // Non-nullable field is uninitialized.
         private Booking()
        {
            _dependents = new List<Dependent>();
        }
        #pragma warning restore CS8618 // Re-enable warning after this class
    }
}