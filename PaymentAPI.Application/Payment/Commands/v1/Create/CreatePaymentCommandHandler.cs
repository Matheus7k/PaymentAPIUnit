using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PaymentAPI.Application.Strategies;
using PaymentAPI.Domain.Contracts;

namespace PaymentAPI.Application.Payment.Commands.v1.Create
{
    public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, ActionResult<Domain.Entities.v1.Payment>>
    {
        private readonly IMapper _mapper;
        private readonly IPaymentFactory _paymentFactory;
        private readonly StrategyImpl _strategy;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<Domain.Entities.v1.Payment> _paymentRepository;

        public CreatePaymentCommandHandler(StrategyImpl strategy, IUnitOfWork unitOfWork, IPaymentFactory paymentFactory, IMapper mapper, IBaseRepository<Domain.Entities.v1.Payment> paymentRepository)
        {
            _mapper = mapper;
            _strategy = strategy;
            _paymentFactory = paymentFactory;
            _unitOfWork = unitOfWork;
            _paymentRepository = paymentRepository;
        }

        public async Task<ActionResult<Domain.Entities.v1.Payment>> Handle(CreatePaymentCommand command, CancellationToken cancellation)
        {
            try
            {
                var entity = _mapper.Map<Domain.Entities.v1.Payment>(command);

                var strategy = _paymentFactory.GetStrategy(entity.PaymentForm);

                entity.Price = _strategy.ExecutePayment(strategy, entity.Price);

                _paymentRepository.InsertAsync(entity);

                await _unitOfWork.Commit();

                return entity;
            }
            catch
            {
                return new BadRequestObjectResult("Metodo de pagamento não encontrado!");
            }
        }
    }
}
