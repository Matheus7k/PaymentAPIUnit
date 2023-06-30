using AutoMapper;
using MediatR;
using PaymentAPI.Domain.Contracts;

namespace PaymentAPI.Application.Queries.Order.v1.List
{
    public class ListOrderQueryHandler : IRequestHandler<ListOrderQuery, IEnumerable<ListOrderQueryResponse>>
    {
        private readonly IBaseRepository<Domain.Entities.v1.Order> _orderRepository;
        private readonly IMapper _mapper;

        public ListOrderQueryHandler(IMapper mapper, IBaseRepository<Domain.Entities.v1.Order> orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;

        }

        public async Task<IEnumerable<ListOrderQueryResponse>> Handle(ListOrderQuery query, CancellationToken cancellation)
        {
            var orders = await _orderRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<ListOrderQueryResponse>>(orders);
        }
    }
}
