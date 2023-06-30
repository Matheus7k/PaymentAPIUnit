using MediatR;

namespace PaymentAPI.Application.Order.Queries.v1.List
{
    public class ListOrderQuery : IRequest<IEnumerable<ListOrderQueryResponse>>
    {
    }
}
