using System.Threading;
using System.Threading.Tasks;
using Application.Cars.Commands.CreateCarCommands;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[controller]")]
    public class CarController : ApiController<CarController>
    {
        [HttpPost]
        public async Task<ActionResult<string>> AddCar(CreateCarCommand command, CancellationToken cancellationToken)
        {
           return Ok(await Mediator.Send(command, cancellationToken));
        }
    }
}