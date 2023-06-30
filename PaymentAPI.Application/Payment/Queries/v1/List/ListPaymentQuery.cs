using MediatR;

namespace PaymentAPI.Application.Payment.Queries.v1.List
{
    public class ListPaymentQuery : IRequest<IEnumerable<ListPaymentQueryResponse>>
    {
    }
}
