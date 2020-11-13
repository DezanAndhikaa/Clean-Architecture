using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Commons.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Car> Cars { get; set; }
        DbSet<Customer> Customers { get; set; }
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken);
    }
}