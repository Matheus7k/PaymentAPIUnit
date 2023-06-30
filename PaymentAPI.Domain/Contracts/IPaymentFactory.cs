namespace PaymentAPI.Domain.Contracts
{
    public interface IPaymentFactory
    {
        public IStrategy GetStrategy(string paymentForm);
    }
}
