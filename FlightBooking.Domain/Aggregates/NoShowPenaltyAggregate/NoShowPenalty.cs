
using FlightBooking.Domain.Aggregates.BookingAggregate;
using FlightBooking.Domain.Aggregates.FlightSeatAggregate;
using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;
using FlightBooking.Domain.SharedKennel.ValueObjects;

namespace FlightBooking.Domain.Aggregates.NoShowPenaltyAggregate
{
    public class NoShowPenalty: Entity<NoShowPenaltyId> ,IAggregateRoot
    {
        public BookingId BookingId { get; private set; }
        public Percentage Percentage { get; private set; }
        public Money CalculatedPenalty { get; private set; }
        public FlyingStatus FlyingStatus { get; private set; }
        public Season Season { get; private set; }

        public NoShowPenalty(BookingId bookingId, SeatClass seatClass, Money ticketPrice, FlyingStatus flyingStatus)
        {
            BookingId = bookingId;
            FlyingStatus = flyingStatus;
            Percentage = CalculatePenaltyPercentage(seatClass);
            CalculatedPenalty = CalculatePenalty(ticketPrice);
            Month currentMonth = Month.GetCurrentMonth();
            Season = currentMonth.IsPeakSeason() ? Season.PeakSeason : Season.NotPeakSeason;
        }

        private Percentage CalculatePenaltyPercentage(SeatClass seatClass)
        {
            Percentage basePercentage;

            switch (seatClass)
            {
                case var sc when sc == SeatClass.Economy:
                    basePercentage = new Percentage(50); // Default to maximum for economy
                    break;
                case var sc when sc == SeatClass.Business:
                    basePercentage = new Percentage(30); // Default to maximum for business
                    break;
                case var sc when sc == SeatClass.FirstClass:
                    basePercentage = new Percentage(20); // Default to maximum for first class
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(seatClass), "Invalid seat class");
            }

            // Apply discounts for frequent flyers
            if (FlyingStatus.IsFrequentFlyer(FlyingStatus))
            {
                basePercentage -= 10;
            }

            // Apply surcharges for peak season
            Month currentMonth = Month.GetCurrentMonth();
            if (currentMonth.IsPeakSeason())
            {
                basePercentage += 10;
            }

            // Ensure percentage is within valid range
            if (basePercentage < 0)
            {
                basePercentage = 0;
            }
            else if (basePercentage > 100)
            {
                basePercentage = 100;
            }

            return basePercentage;
        }

        private Money CalculatePenalty(Money ticketPrice)
        {
            return ticketPrice * Percentage.ToFraction();
        }

        public static implicit operator NoShowPenalty((BookingId bookingId, SeatClass seatClass, decimal ticketPrice, FlyingStatus flyingStatus) values)
        {
            return new NoShowPenalty(values.bookingId, values.seatClass, new Money(values.ticketPrice), values.flyingStatus);
        }

        public static implicit operator (decimal percentage, decimal calculatedPenalty)(NoShowPenalty penalty)
        {
            return (penalty.Percentage.Value, penalty.CalculatedPenalty.Amount);
        }

        public override string ToString()
        {
            return $"No-Show Penalty: {Percentage} or {CalculatedPenalty}";
        }

        #pragma warning disable CS8618 // Non-nullable field is uninitialized.
        private NoShowPenalty() 
        {
        }
        #pragma warning restore CS8618 // Re-enable warning after this class
    }
}