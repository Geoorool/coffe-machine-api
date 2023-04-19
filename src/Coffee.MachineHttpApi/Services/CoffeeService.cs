using MachineHttpApi.Models;
using MachineHttpApi.Services.Interfaces;

namespace MachineHttpApi.Services;

public class CoffeeService : ICoffeeService
{
    private List<Coffee> _coffees = new ();

    public Task<Coffee> CreateCoffee(CoffeeCreationModel coffee, CancellationToken _) {
        long coffeeId = _coffees.Count == 0 ? 1 : _coffees.Max(c => c.Id) + 1;
        var newCoffee = new Coffee {
            Id = coffeeId,
            Name = coffee.Name,
            SugarAmount = coffee.SugarAmount,
            MilkAmount = coffee.MilkAmount
        };
        _coffees.Add(newCoffee);
        return Task.FromResult(newCoffee);
    }
}