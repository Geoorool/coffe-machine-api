using MachineHttpApi.Models;

namespace MachineHttpApi.Services.Interfaces;

public interface ICoffeeService
{
    Task<Coffee> CreateCoffee(CoffeeCreationModel coffee, CancellationToken token);
}