using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Commons.Interfaces;
using Application.Commons.Models;
using Domain.Entities;
using MediatR;

namespace Application.Cars.Commands.CreateCarCommands
{
    public class CreateCarCommand : IRequest<string>
    {
        public Car car { get; set; }
    }

    public class CreateCarCommandHandler : BaseCommand, IRequestHandler<CreateCarCommand, string>
    {
        public CreateCarCommandHandler(IAppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<string> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            request.car.IdGuid = Guid.NewGuid();

            await DbContext.Cars.AddAsync(request.car, cancellationToken);
            await DbContext.SaveChangesAsync(true, cancellationToken);
            return "Anjing";
        }
    }
}