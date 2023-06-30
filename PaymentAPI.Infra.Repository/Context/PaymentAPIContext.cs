using Microsoft.EntityFrameworkCore;

namespace PaymentAPI.Infra.Repository.Context
{
    public class PaymentAPIContext : DbContext
    {
        public PaymentAPIContext(DbContextOptions<PaymentAPIContext> options) : base(options)
        {
        }

        public DbSet<PaymentAPI.Domain.Entities.v1.Payment> Payment { get; set; } = default!;

        public DbSet<PaymentAPI.Domain.Entities.v1.Order>? Order { get; set; }
    }
}

