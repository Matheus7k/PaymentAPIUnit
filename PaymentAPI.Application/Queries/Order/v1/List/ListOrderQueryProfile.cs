using AutoMapper;

namespace PaymentAPI.Application.Queries.Order.v1.List
{
    public class ListOrderQueryProfile : Profile
    {
        public ListOrderQueryProfile()
        {
            CreateMap<Domain.Entities.v1.Order, ListOrderQueryResponse>()
                .ForMember(fieldOutPut => fieldOutPut.ProductName, option => option
                    .MapFrom(input => input.ProductName))
                .ForMember(fieldOutPut => fieldOutPut.Quantity, option => option
                    .MapFrom(input => input.Quantity))
                .ForMember(fieldOutPut => fieldOutPut.Amount, option => option
                    .MapFrom(input => input.Amount));
        }
    }
}
