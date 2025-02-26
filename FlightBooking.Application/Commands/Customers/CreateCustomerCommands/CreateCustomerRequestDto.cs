using FlightBooking.Domain.Aggregates.CustomerAggregate;

namespace FlightBooking.Application.Commands.Customers.CreateCustomerCommands
{
      public class CreateCustomerRequestDto
    {
        public required string FirstName { get; set; } 
        public required string LastName { get; set; }
        public required string MiddleName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Street { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string ZipCode { get; set; }

        public static implicit operator CreateCustomerCommand(CreateCustomerRequestDto request)
        {
            return new CreateCustomerCommand(
                request.FirstName,
                request.LastName,
                request.MiddleName,
                request.Email,
                request.PhoneNumber,
                new Address(
                    request.Street,
                    request.City,
                    request.State,
                    request.ZipCode
                )
            );
        }
    }
}