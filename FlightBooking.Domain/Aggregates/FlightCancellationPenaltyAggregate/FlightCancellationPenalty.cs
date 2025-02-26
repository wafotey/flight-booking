using FlightBooking.Domain.Aggregates.BookingAggregate;
using FlightBooking.Domain.Aggregates.FlightCancellationPenaltySettingsAggregate;
using FlightBooking.Domain.Aggregates.FlightSeatAggregate;
using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.ValueObjects;

namespace FlightBooking.Domain.Aggregates.FlightCancellationPenaltyAggregate
{

    public class FlightCancellationPenalty : Entity<FlightCancellationPenaltyId>, IAggregateRoot
    {
        private const int CANCELLATION_HOURS = 48;
        public BookingId BookingId { get; private set; }
        public Percentage Percentage { get; private set; } = 0;
        public Money CalculatedPenalty { get; private set; } = 0;

        public FlightCancellationPenalty(
            BookingId bookingId, 
            SeatClass seatClass, 
            Money ticketPrice, 
            DateTime cancellationTime, 
            DateTime departureTime, 
            FlightCancellationPenaltySettings flightCancellationPenaltySettings)
        {
            if (IsCancellationLessThan48Hours(cancellationTime,departureTime))
            {
                Percentage = CalculatePenaltyPercentage(seatClass, flightCancellationPenaltySettings);
                CalculatedPenalty = CalculatePenalty(ticketPrice);
            }
            BookingId = bookingId;
        }

        private bool IsCancellationLessThan48Hours(DateTime cancellationTime, DateTime departureTime)
        {
            return (departureTime - cancellationTime).TotalHours <= CANCELLATION_HOURS;
        }

        private Percentage CalculatePenaltyPercentage(
            SeatClass seatClass, 
            FlightCancellationPenaltySettings flightCancellationPenaltySettings)
        {
            return seatClass switch
            {
                var sc when sc == SeatClass.Economy => flightCancellationPenaltySettings.EconomyClassPenaltyPercentage, // Default to minimum for economy
                var sc when sc == SeatClass.Business => flightCancellationPenaltySettings.BusinessClassPenaltyPercentage, // Default to minimum for business
                var sc when sc == SeatClass.FirstClass => flightCancellationPenaltySettings.FirstClassPenaltyPercentage, // Default to minimum for first class
                _ => throw new ArgumentOutOfRangeException(nameof(seatClass), "Invalid seat class")
            };
        }

        private Money CalculatePenalty(Money ticketPrice)
        {
            return ticketPrice * Percentage.ToFraction();
        }

        public static implicit operator FlightCancellationPenalty(
            (BookingId bookingId, 
            SeatClass seatClass, 
            decimal ticketPrice, 
            DateTime cancellationTime, 
            DateTime departureTime, 
            FlightCancellationPenaltySettings flightCancellationPenaltySettings) values)
        {
            return new FlightCancellationPenalty(
                values.bookingId, 
                values.seatClass, 
                new Money(values.ticketPrice), 
                values.cancellationTime, 
                values.departureTime, 
                values.flightCancellationPenaltySettings);
        }

        public static implicit operator (
            decimal percentage,
            decimal calculatedPenalty)
            (FlightCancellationPenalty penalty)
        {
            return (penalty.Percentage.Value, penalty.CalculatedPenalty.Amount);
        }

        public override string ToString()
        {
            return $"Cancellation Penalty: {Percentage} or {CalculatedPenalty}";
        }

          #pragma warning disable CS8618 // Non-nullable field is uninitialized.
         private FlightCancellationPenalty() 
        {
        }
        #pragma warning restore CS8618 // Re-enable warning after this class
    }
}