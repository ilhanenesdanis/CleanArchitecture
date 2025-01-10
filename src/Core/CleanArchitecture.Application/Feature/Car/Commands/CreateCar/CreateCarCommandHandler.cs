using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Feature.Car.Commands.CreateCar;

public sealed class CreateCarCommandHandler : IRequestHandler<CreateCarCommandRequest, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateCarCommandRequest request, CancellationToken cancellationToken)
    {
        return new MessageResponse("Car Created");
    }
}
