using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Reponses;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Handlers;

namespace Shop.Controllers 
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        //public CreateCustomerResponse Create(
        public Task<CreateCustomerResponse> Create(
            //[FromServices]ICreateCustomerHandler handler, 
            [FromServices]IMediator mediator, 
            [FromBody]CreateCustomerRequest command)
        {
            // return handler.Handle(command);
            return mediator.Send(command);
        }
    }
}