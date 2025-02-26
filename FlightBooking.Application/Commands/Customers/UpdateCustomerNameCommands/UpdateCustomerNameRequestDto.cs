using FlightBooking.Domain.Aggregates.CustomerAggregate;

namespace FlightBooking.Application.Commands.Customers.UpdateCustomerNameCommands
{
    public class UpdateCustomerNameRequestDto
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; } 
        public required string LastName { get; set; }
        public required string MiddleName { get; set; }

        public static implicit operator UpdateCustomerNameCommand(UpdateCustomerNameRequestDto request)
        {
            return new UpdateCustomerNameCommand(
                new CustomerId(request.Id),
                request.FirstName,
                request.LastName,
                request.MiddleName
            );
        }
    }
}