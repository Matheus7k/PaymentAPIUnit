using Microsoft.EntityFrameworkCore;
using PaymentAPI.Domain.Contracts;

namespace PaymentAPI.Infra.Repository.Repositories
{
    public class SqlRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _sqlContext;

        public SqlRepository(DbContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _sqlContext.Set<TEntity>().ToListAsync();
        }

        public async void InsertAsync(TEntity entity)
        {
            await _sqlContext.Set<TEntity>().AddAsync(entity);
        }
    }
}
