using FlightBooking.Application.Utilities;
using FlightBooking.Domain.Aggregates.CustomerAggregate;
using LanguageExt.Common;
using MediatR;

namespace FlightBooking.Application.Commands.Customers.UpdateCustomerNameCommands
{
    public class UpdateCustomerNameCommand: IRequest<Result<CommandResult>>
    {
        public CustomerId CustomerId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }

        public UpdateCustomerNameCommand(
            CustomerId customerId, 
            string firstName, 
            string lastName, 
            string middleName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
    }
}