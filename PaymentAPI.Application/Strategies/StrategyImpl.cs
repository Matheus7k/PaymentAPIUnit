using PaymentAPI.Domain.Contracts;

namespace PaymentAPI.Application.Strategies
{
    public class StrategyImpl
    {
        public double ExecutePayment(IStrategy strategy, double price)
        {
            return strategy.Pay(price);
        }
    }
}
