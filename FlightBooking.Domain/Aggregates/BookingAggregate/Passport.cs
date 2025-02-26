using FlightBooking.Domain.Aggregates.BookingAggregate.Exceptions;
using FlightBooking.Domain.SharedKennel;
using FlightBooking.Domain.SharedKennel.Enumerations;

namespace FlightBooking.Domain.Aggregates.BookingAggregate
{
    public class Passport : Entity<PassportId>
    {
        public Nationality Nationality { get; private set; }
        public string PassportNumber { get; private set; }
        public Country IssuingCountry { get; private set; }
        public DateOnly ExpiryDate { get; private set; }
        public DateOnly IssueDate { get; private set; }



        public Passport(Nationality nationality, string passportNumber, Country issuingCountry, DateOnly expiryDate, DateOnly issueDate)
        {
            if (IssueDate > ExpiryDate)
            {
                throw new InvalidPassportIssueDateDomainException("Passport issue date cannot be later than the expiry date.");
            }
            if (IsPassportExpired)
            {
                throw new PassportExpiredDomainException("Passport has expired.");
            }

            Nationality = nationality;
            PassportNumber = passportNumber;
            IssuingCountry = issuingCountry;
            ExpiryDate = expiryDate;
            IssueDate = issueDate;
        }

        private bool IsPassportExpired => ExpiryDate < DateOnly.FromDateTime(DateTime.UtcNow);



#pragma warning disable CS8618 // Non-nullable field is uninitialized.
        private Passport()
        {
        }
#pragma warning restore CS8618 // Re-enable warning after this class
    }
}