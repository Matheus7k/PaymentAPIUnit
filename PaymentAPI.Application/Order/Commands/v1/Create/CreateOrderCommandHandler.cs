using AutoMapper;
using MediatR;
using PaymentAPI.Domain.Contracts;

namespace PaymentAPI.Application.Order.Commands.v1.Create
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Domain.Entities.v1.Order>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<Domain.Entities.v1.Order> _orderRepository;


        public CreateOrderCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IBaseRepository<Domain.Entities.v1.Order> orderRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _orderRepository = orderRepository;

        }

        public async Task<Domain.Entities.v1.Order> Handle(CreateOrderCommand command, CancellationToken cancellation)
        {
            var entity = _mapper.Map<Domain.Entities.v1.Order>(command);

            _orderRepository.InsertAsync(entity);

            await _unitOfWork.Commit();

            return entity;
        }
    }
}
