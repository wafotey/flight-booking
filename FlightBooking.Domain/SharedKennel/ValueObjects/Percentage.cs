using FlightBooking.Domain.SharedKennel.Exceptions;

namespace FlightBooking.Domain.SharedKennel.ValueObjects
{
    public class Percentage
    {
        public decimal Value { get; private set; }

        public Percentage(decimal value)
        {
            if (value < 0 || value > 100)
            {
                throw new InvalidFractionDomainException("Percentage value must be between 0 and 100.");
            }
            Value = value;
        }

        public static implicit operator Percentage(decimal value)
        {
            return new Percentage(value);
        }

        public static implicit operator decimal(Percentage percentage)
        {
            return percentage.Value;
        }

        public override string ToString()
        {
            return $"{Value}%";
        }

        public static Percentage FromFraction(decimal fraction)
        {
            if (fraction < 0 || fraction > 1)
            {
                throw new InvalidFractionDomainException( "Fraction must be between 0 and 1.");
            }
            return new Percentage(fraction * 100);
        }

        public decimal ToFraction()
        {
            return Value / 100;
        }
    }
}