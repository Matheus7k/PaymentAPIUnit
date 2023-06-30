using MediatR;

namespace PaymentAPI.Application.Queries.Payment.v1.List
{
    public class ListPaymentQuery : IRequest<IEnumerable<ListPaymentQueryResponse>>
    {
    }
}
