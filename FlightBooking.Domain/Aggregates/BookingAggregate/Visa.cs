using FlightBooking.Domain.Aggregates.BookingAggregate.Exceptions;
using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;

namespace FlightBooking.Domain.Aggregates.BookingAggregate
{
    public class Visa : ValueObject
    {
        public VisaType VisaType { get; private set; }
        public string VisaNumber { get; private set; }
        public DateOnly IssueDate { get; private set; }
        public DateOnly ExpiryDate { get; private set; }
        public Country IssuingCountry { get; private set; }

       

        public Visa(
            VisaType visaType,
            string visaNumber,
            DateOnly issueDate,
            DateOnly expiryDate,
            Country issuingCountry)
        {
            if (IssueDate > ExpiryDate)
            {
                throw new InvalidVisaIssueDateDomainException("Visa issue date cannot be later than the expiry date.");
            }
            if (IsVisaExpired)
            {
                throw new VisaExpiredDomainException("Visa has expired.");
            }

            VisaType = visaType;
            VisaNumber = visaNumber;
            IssueDate = issueDate;
            ExpiryDate = expiryDate;
            IssuingCountry = issuingCountry;
        }

        private bool IsVisaExpired => ExpiryDate < DateOnly.FromDateTime(DateTime.UtcNow);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new object[] { VisaType, VisaNumber, IssueDate, ExpiryDate, IssuingCountry };
        }

    #pragma warning disable CS8618 // Non-nullable field is uninitialized.
         private Visa() 
        {
        }
        #pragma warning restore CS8618 // Re-enable warning after this class
    }
}