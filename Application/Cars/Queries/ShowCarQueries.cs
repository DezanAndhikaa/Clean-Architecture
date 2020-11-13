using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using Application.Commons.Interfaces;
using Application.Commons.Models;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Cars.Queries
{
    public class ShowCarQueries : BaseCommand
    {
        public ShowCarQueries(CancellationToken cancellationToken, IAppDbContext appDbContext) : base(cancellationToken, appDbContext)
        {
        }

        public async Task<List<Car>> ShowCar()
        {
            return await DbContext.Cars.ToListAsync(_cancellationToken);
        }
    }
}