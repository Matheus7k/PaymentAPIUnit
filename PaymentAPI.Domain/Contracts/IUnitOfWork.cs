namespace PaymentAPI.Domain.Contracts
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
