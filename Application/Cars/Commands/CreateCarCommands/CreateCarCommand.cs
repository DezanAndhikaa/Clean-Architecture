using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Application.Commons.Interfaces;
using Application.Commons.Models;
using Domain.Entities;

namespace Application.Cars.Commands.CreateCarCommands
{
    public class CreateCarCommand : BaseCommand
    {
        private Car _car;
        public CreateCarCommand(IAppDbContext dbContext, CancellationToken cancellationToken, Car car) : base(cancellationToken, dbContext)
        {
            _car = car;
        }

        public async Task<string> AddCarCommand()
        {
            if (_car.CarName == null) return "Failed";
            await DbContext.Cars.AddAsync(_car, _cancellationToken);
            await DbContext.SaveChangesAsync(true, _cancellationToken);
            return "Succeed";
        }
    }
}