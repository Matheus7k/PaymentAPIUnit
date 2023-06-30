using AutoMapper;

namespace PaymentAPI.Application.Payment.Commands.v1.Create
{
    public class CreatePaymentCommandProfile : Profile
    {
        public CreatePaymentCommandProfile()
        {
            CreateMap<CreatePaymentCommand, Domain.Entities.v1.Payment>()
                .ForMember(fieldOutPut => fieldOutPut.Cpf, option => option
                    .MapFrom(input => input.Cpf))
                .ForMember(fieldOutPut => fieldOutPut.Price, option => option
                    .MapFrom(input => input.Price))
                .ForMember(fieldOutPut => fieldOutPut.PaymentForm, option => option
                    .MapFrom(input => input.PaymentForm));
        }
    }
}
