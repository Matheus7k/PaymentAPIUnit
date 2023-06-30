namespace PaymentAPI.Domain.Contracts
{
    public interface IBaseRepository<TEntity>
    {
        void InsertAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
