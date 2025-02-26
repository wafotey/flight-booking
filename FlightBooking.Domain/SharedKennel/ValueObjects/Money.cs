using FlightBooking.Domain.SharedKennel.Enumerations;

namespace FlightBooking.Domain.SharedKennel.ValueObjects
{
  	public class Money: ValueObject
    {
        public Currency Currency { get; private set; }
        public decimal Amount { get; private set; }

        public Money(decimal amount)
        {
            Currency = Currency.USD;
            Amount = amount;
        }

        public static implicit operator Money(decimal amount)
        {
            return new Money(amount);
        }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public Money(Currency currency,decimal amount)
		{
            Currency = currency;
            Amount = amount;
		}

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Currency;
            yield return Amount;
        }

        public static Money operator +(Money left,Money right)
        {
            return new Money(left.Amount + right.Amount);
        }

        public static Money operator -(Money left,Money right)
        {
            return new Money(left.Amount - right.Amount);
        }

        public static bool operator <(Money left,Money right)
        {
            return left.Amount < right.Amount;
        }


        public static bool operator >(Money left, Money right)
        {
            return left.Amount > right.Amount;
        }

        public static bool operator <=(Money left, Money right)
        {
            return left.Amount <= right.Amount;
        }

        public static bool operator >=(Money left, Money right)
        {
            return left.Amount >= right.Amount;
        }
        public static Money operator *(Money left, Money right)
        {
            return new Money(left.Amount * right.Amount);
        }

    }
}