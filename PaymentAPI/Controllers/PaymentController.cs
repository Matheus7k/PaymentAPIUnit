using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentAPI.Application.Commands.Payment.v1.Create;
using PaymentAPI.Application.Queries.Payment.v1.List;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "MakePayment")]
        public async Task<ActionResult<Domain.Entities.v1.Payment>> MakePayment([FromBody] CreatePaymentCommand command, CancellationToken cancellation)
        {
            return await _mediator.Send(command, cancellation);
        }

        [HttpGet(Name = "GetPayments")]
        public async Task<IEnumerable<ListPaymentQueryResponse>> GetPayments(CancellationToken cancellation)
        {
            var query = new ListPaymentQuery();
            return await _mediator.Send(query, cancellation);
        }
    }
}