using System.Threading;
using Application.Commons.Interfaces;
using Domain.Entities;

namespace Application.Commons.Models
{
    public class BaseCommand
    {
        public readonly IAppDbContext DbContext;
        
        public BaseCommand(IAppDbContext appDbContext)
        {
            DbContext = appDbContext;
        }
    }
}