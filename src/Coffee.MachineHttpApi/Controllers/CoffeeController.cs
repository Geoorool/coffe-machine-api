using MachineHttpApi.Models;
using MachineHttpApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MachineHttpApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoffeeController : Controller
{
    private readonly ICoffeeService _coffeeService;
    public CoffeeController(ICoffeeService coffeeService) {
        _coffeeService = coffeeService;
    }

    [HttpPost]
    public async Task<ActionResult<Coffee>> CreateCoffee(CoffeeCreationModel coffee, CancellationToken token) {
        var result = await _coffeeService.CreateCoffee(coffee, token);
        return Ok(result);
    }
}