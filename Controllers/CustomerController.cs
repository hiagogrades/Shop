using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Handlers;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Controllers
{
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public CreateCustomerResponse Create
        (
            [FromServices] ICreateCustomerHandler handler,
            [FromBody] CreateCustomerRequest command
        )
        {
            return handler.Handle(command);
        }
    }
}