using PaymentAPI.Domain.Contracts;

namespace PaymentAPI.Application.Strategies
{
    public class PixStrategy : IStrategy
    {
        public double Pay(double price)
        {
            return price -= price * 0.2;
        }
    }
}
