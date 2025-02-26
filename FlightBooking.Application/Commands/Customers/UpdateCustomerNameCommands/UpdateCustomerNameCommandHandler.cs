using FlightBooking.Application.Utilities;
using FlightBooking.Domain.Aggregates.CustomerAggregate;
using LanguageExt.Common;
using MediatR;

namespace FlightBooking.Application.Commands.Customers.UpdateCustomerNameCommands
{
    public class UpdateCustomerNameCommandHandler : IRequestHandler<UpdateCustomerNameCommand, Result<CommandResult>>
    {
        private readonly ICustomerRepository _customerRepository;
        public UpdateCustomerNameCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }
        public async Task<Result<CommandResult>> Handle(UpdateCustomerNameCommand command, CancellationToken cancellationToken)
        {
            var result = await _customerRepository.GetByIdAsync(command.CustomerId);

            if (result.IsNone) 
                return  new Result<CommandResult>(
                    new Exception($"Cannot upate name. Customer with Id: {command.CustomerId.Value} not found"));
            
            var customer = result.First();

            customer.UpdateName(
                command.FirstName,
                command.LastName,
                command.MiddleName);

            _customerRepository.Update(customer);

            return new Result<CommandResult>(new CommandResult(string.Empty));
        }
    }
}