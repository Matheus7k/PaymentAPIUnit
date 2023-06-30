using MediatR;

namespace PaymentAPI.Application.Queries.Order.v1.List
{
    public class ListOrderQuery : IRequest<IEnumerable<ListOrderQueryResponse>>
    {
    }
}
