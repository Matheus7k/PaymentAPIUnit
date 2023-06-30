using PaymentAPI.Domain.Contracts;

namespace PaymentAPI.Application.Strategies
{
    public class DebtStrategy : IStrategy
    {
        public double Pay(double price)
        {
            return price -= price * 0.1;
        }
    }
}
