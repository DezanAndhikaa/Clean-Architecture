using System.Threading;
using System.Threading.Tasks;
using Application.Commons.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistences
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
        public override async Task<int> SaveChangesAsync (bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default (CancellationToken)) {
            var result = await base.SaveChangesAsync (acceptAllChangesOnSuccess, cancellationToken);
            return result;
        }
    }
}