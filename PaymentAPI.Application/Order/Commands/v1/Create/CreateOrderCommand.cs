using MediatR;

namespace PaymentAPI.Application.Order.Commands.v1.Create
{
    public class CreateOrderCommand : IRequest<Domain.Entities.v1.Order>
    {
        public CreateOrderCommand(string productName, int quantity, double unitPrice)
        {
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
