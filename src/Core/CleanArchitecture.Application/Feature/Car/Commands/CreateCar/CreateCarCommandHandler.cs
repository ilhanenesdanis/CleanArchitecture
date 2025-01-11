using CleanArchitecture.Application.Service;
using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Feature.Car.Commands.CreateCar;

public sealed class CreateCarCommandHandler : IRequestHandler<CreateCarCommandRequest, MessageResponse>
{
    private readonly ICarService _carService;

    public CreateCarCommandHandler(ICarService carService)
    {
        _carService = carService;
    }

    public async Task<MessageResponse> Handle(CreateCarCommandRequest request, CancellationToken cancellationToken)
    {

        await _carService.CreateAsync(request, cancellationToken);
        return new MessageResponse("Car Created");
    }
}
