
using CleanArchitecture.Application.Feature.Car.Commands.CreateCar;
using CleanArchitecture.Application.Service;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;

namespace CleanArchitecture.Persistence.Service
{
    public class CarService : ICarService
    {
        private readonly AppDbContext _context;

        public CarService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateCarCommandRequest request, CancellationToken cancellationToken)
        {
            Car car = new Car()
            {
                Name = request.Name,
                Model = request.Model,
                EnginePower = request.EnginePower,
            };

            await _context.Set<Car>().AddAsync(car, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
