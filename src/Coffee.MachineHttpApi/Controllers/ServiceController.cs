using Microsoft.AspNetCore.Mvc;

namespace MachineHttpApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ServiceController : Controller
{
    [HttpGet]
    public IActionResult RemainingProducts() {
        var info = new { Coffee = 100, Milk = 100, Sugar = 100 };
        return Ok(info);
    }
    
    [HttpPost]
    public IActionResult TopUpProducts() {
        var info = new { Coffee = 100, Milk = 100, Sugar = 100 };
        return Ok(info);
    }
    
}