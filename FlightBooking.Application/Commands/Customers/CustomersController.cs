
using FlightBooking.Application.Commands.Customers.CreateCustomerCommands;
using FlightBooking.Application.Commands.Customers.UpdateCustomerNameCommands;
using FlightBooking.Application.Utilities;
using LanguageExt.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Application.Commands.Customers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomersController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        [HttpPost("create")]
        public async Task<IActionResult> Post(CreateCustomerRequestDto request)
        {
            CreateCustomerCommand command = request;
            bool result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("change-name")]
        public async Task<IActionResult> Put(UpdateCustomerNameRequestDto request)
        {
            UpdateCustomerNameCommand command = request;
            Result<CommandResult> commandResult = await _mediator.Send(command);
            if (commandResult.IsFaulted)
                return NotFound(commandResult.ToString());
            return Ok();
        }
    }
}