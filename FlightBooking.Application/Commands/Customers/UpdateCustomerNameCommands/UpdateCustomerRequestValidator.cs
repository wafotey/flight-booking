using FluentValidation;

namespace FlightBooking.Application.Commands.Customers.UpdateCustomerNameCommands
{
    public class UpdateCustomerRequestValidator: AbstractValidator<UpdateCustomerNameRequestDto>
    {
        public UpdateCustomerRequestValidator(ILogger<UpdateCustomerNameRequestDto> logger){
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.MiddleName).NotEmpty();

           logger.LogTrace("INSTANCE CREATED - {ClassName}", GetType().Name);
        }
    }
}