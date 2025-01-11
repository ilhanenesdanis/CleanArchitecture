using CleanArchitecture.Application.Feature.Car.Commands.CreateCar;

namespace CleanArchitecture.Application.Service;

public interface ICarService
{
    Task CreateAsync(CreateCarCommandRequest request, CancellationToken cancellationToken);
}
