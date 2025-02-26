using FlightBooking.Domain.Aggregates.CustomerAggregate;
using MediatR;

namespace FlightBooking.Application.Commands.Customers.CreateCustomerCommands
{
    public class CreateCustomerCommand: IRequest<bool>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public Address Address { get; private set; }

        public CreateCustomerCommand(
            string firstName,
            string lastName,
            string middleName,
            string email,
            string phoneNumber,
            Address address
        )
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}