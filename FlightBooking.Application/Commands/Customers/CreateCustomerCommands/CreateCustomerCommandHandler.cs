using FlightBooking.Domain.Aggregates.CustomerAggregate;
using MediatR;

namespace FlightBooking.Application.Commands.Customers.CreateCustomerCommands
{
     public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, bool>
    {
        private readonly ICustomerRepository _customerRepository; 
        public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository?? throw new ArgumentNullException(nameof(customerRepository));
        }
        public Task<bool> Handle(CreateCustomerCommand command, CancellationToken cancellationToken)
        {
            var customer = new Customer(
                command.FirstName, 
                command.LastName, 
                command.MiddleName,
                command.Email,
                command.PhoneNumber, 
                command.Address);

            _customerRepository.Add(customer);

            return Task.FromResult(true);
        }
    }
}