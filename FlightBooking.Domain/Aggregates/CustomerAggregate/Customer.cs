using FlightBooking.Domain.SharedKennel;

namespace FlightBooking.Domain.Aggregates.CustomerAggregate
{
    
    public class Customer : Entity<CustomerId>, IAggregateRoot
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public Address Address { get; private set; }
        public Customer(
            string firstName,
            string lastName,
            string middleName,
            string email,
            string phoneNumber,
            Address address
            )
        {
            Id = new CustomerId(Guid.NewGuid());
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public void UpdateName(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        #pragma warning disable CS8618 // Non-nullable field is uninitialized.
        private Customer()
        {
        }
        #pragma warning restore CS8618 // Re-enable warning after this class
    }
}