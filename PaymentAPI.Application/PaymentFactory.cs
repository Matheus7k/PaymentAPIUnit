using PaymentAPI.Domain.Contracts;

namespace PaymentAPI.Application
{
    public class PaymentFactory : IPaymentFactory
    {
        private readonly IEnumerable<IStrategy> _strategies;

        public PaymentFactory(IEnumerable<IStrategy> strategies)
        {
            _strategies = strategies;
        }

        public IStrategy GetStrategy(string paymentForm)
        {
            try
            {
                var strategy = _strategies.Where(strategy => strategy.GetType().Name.Equals($"{paymentForm}Strategy", StringComparison.InvariantCultureIgnoreCase)).First();

                return strategy;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
