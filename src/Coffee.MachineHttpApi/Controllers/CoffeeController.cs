using Microsoft.AspNetCore.Mvc;

namespace MachineHttpApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoffeeController : Controller
{
    [HttpPost]
    public IActionResult CreateCoffee() {
        var coffee = new { Name = "Cappuccino", Sugar = 5, Milk = 3 };
        return Ok(coffee);
    }
}