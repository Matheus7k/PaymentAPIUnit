namespace PaymentAPI.Application.Queries.Payment.v1.List
{
    public class ListPaymentQueryResponse
    {
        public string Cpf { get; set; }
        public string PaymentForm { get; set; }
        public double Price { get; set; }
    }
}
