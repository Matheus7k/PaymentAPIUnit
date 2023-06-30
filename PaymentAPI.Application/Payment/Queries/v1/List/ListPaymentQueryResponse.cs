namespace PaymentAPI.Application.Payment.Queries.v1.List
{
    public class ListPaymentQueryResponse
    {
        public string Cpf { get; set; }
        public string PaymentForm { get; set; }
        public double Price { get; set; }
    }
}
