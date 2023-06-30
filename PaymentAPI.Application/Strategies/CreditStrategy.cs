using PaymentAPI.Domain.Contracts;

namespace PaymentAPI.Application.Strategies
{
    public class CreditStrategy : IStrategy
    {
        public double Pay(double price)
        {
            return price += price * 0.15;
        }
    }
}
