namespace PaymentAPI.Domain.Entities.v1
{
    public class Payment
    {
        public Payment(string cpf, string paymentForm, double price)
        {
            Id = new Guid();
            Cpf = cpf;
            PaymentForm = paymentForm;
            Price = price;
        }

        public Guid Id { get; set; }
        public string Cpf { get; set; }
        public string PaymentForm { get; set; }
        public double Price { get; set; }
    }
}
