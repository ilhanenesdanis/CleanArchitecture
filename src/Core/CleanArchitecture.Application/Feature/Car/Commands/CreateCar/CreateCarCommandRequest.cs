using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Feature.Car.Commands.CreateCar;

public sealed record CreateCarCommandRequest(string name, string model, int enginePower) : IRequest<MessageResponse>;
