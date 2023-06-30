using AutoMapper;

namespace PaymentAPI.Application.Commands.Order.v1.Create
{
    public class CreateOrderCommandProfile : Profile
    {
        public CreateOrderCommandProfile()
        {
            CreateMap<CreateOrderCommand, Domain.Entities.v1.Order>()
                .ForMember(fieldOutPut => fieldOutPut.ProductName, option => option
                    .MapFrom(input => input.ProductName))
                .ForMember(fieldOutPut => fieldOutPut.Quantity, option => option
                    .MapFrom(input => input.Quantity))
                .ForMember(fieldOutPut => fieldOutPut.UnitPrice, option => option
                    .MapFrom(input => input.UnitPrice));
        }
    }
}
