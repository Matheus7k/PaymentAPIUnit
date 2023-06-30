using AutoMapper;

namespace PaymentAPI.Application.Payment.Queries.v1.List
{
    public class ListPaymentQueryProfile : Profile
    {
        public ListPaymentQueryProfile()
        {
            CreateMap<Domain.Entities.v1.Payment, ListPaymentQueryResponse>()
                .ForMember(fieldOutput => fieldOutput.Cpf, option => option
                    .MapFrom(input => input.Cpf))
                .ForMember(fieldOutput => fieldOutput.PaymentForm, option => option
                    .MapFrom(input => input.PaymentForm))
                .ForMember(fieldOutput => fieldOutput.Price, option => option
                    .MapFrom(input => input.Price));
        }
    }
}
