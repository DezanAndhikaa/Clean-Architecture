using System.Threading;
using Application.Commons.Interfaces;
using Domain.Entities;

namespace Application.Commons.Models
{
    public class BaseCommand
    {
        public readonly IAppDbContext DbContext;
        public readonly CancellationToken _cancellationToken;
        
        public BaseCommand(CancellationToken cancellationToken, IAppDbContext appDbContext)
        {
            _cancellationToken = cancellationToken;
            DbContext = appDbContext;
        }
    }
}