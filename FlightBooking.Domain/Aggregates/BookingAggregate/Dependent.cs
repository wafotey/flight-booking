using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.BookingAggregate
{
    public class Dependent : Entity<DependentId>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }
        public DateTime DateOfBirth { get; private set; }


        public Dependent(string firstName, string lastName, string middleName, DateTime dateOfBirth)
        {
            Id = new DependentId(Guid.NewGuid());
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
        }
#pragma warning disable CS8618 // Non-nullable field is uninitialized.
        private Dependent()
        {
        }
    }
}