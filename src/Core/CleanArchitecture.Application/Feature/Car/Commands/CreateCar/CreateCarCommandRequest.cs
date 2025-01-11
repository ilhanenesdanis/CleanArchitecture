using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Feature.Car.Commands.CreateCar;

public sealed record CreateCarCommandRequest(string Name, string Model, int EnginePower) : IRequest<MessageResponse>;
