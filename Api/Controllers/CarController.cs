using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Cars.Commands.CreateCarCommands;
using Application.Commons.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController
    {
        private IAppDbContext _appDbContext;

        public CarController(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<ActionResult<string>> AddCar(Car car, CancellationToken cancellationToken)
        {
            var command = new CreateCarCommand(_appDbContext,cancellationToken, car);
            return await command.AddCarCommand();
        }
    }
}