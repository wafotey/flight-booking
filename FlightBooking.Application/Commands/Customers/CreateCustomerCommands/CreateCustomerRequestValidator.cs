using FluentValidation;

namespace FlightBooking.Application.Commands.Customers.CreateCustomerCommands
{
    public class CreateCustomerRequestValidator: AbstractValidator<CreateCustomerRequestDto>
    {
        public CreateCustomerRequestValidator(ILogger<CreateCustomerRequestDto> logger){
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.MiddleName).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.Street).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.State).NotEmpty();
            RuleFor(x => x.ZipCode).NotEmpty();

           logger.LogTrace("INSTANCE CREATED - {ClassName}", GetType().Name);
        }
    }
}