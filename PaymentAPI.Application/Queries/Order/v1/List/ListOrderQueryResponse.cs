namespace PaymentAPI.Application.Queries.Order.v1.List
{
    public class ListOrderQueryResponse
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}
