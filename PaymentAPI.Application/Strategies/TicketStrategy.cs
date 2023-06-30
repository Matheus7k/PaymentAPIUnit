using PaymentAPI.Domain.Contracts;

namespace PaymentAPI.Application.Strategies
{
    public class TicketStrategy : IStrategy
    {
        public double Pay(double price)
        {
            return price;
        }
    }
}
