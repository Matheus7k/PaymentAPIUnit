namespace PaymentAPI.Domain.Entities.v1
{
    public class Order
    {
        public Order(string productName, int quantity, double unitPrice)
        {
            Id = new Guid();
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Amount = Quantity * UnitPrice;
        }

        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Amount { get; set; }
    }
}
