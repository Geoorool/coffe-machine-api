using MachineHttpApi.Models;
using MachineHttpApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MachineHttpApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ServiceController : Controller
{
    private readonly IServiceService _serviceService;
    public ServiceController(IServiceService serviceService) {
        _serviceService = serviceService;
    }

    [HttpGet]
    public async Task<ActionResult<ProductsInfo>> RemainingProducts(CancellationToken token) {
        return Ok(await _serviceService.Info(token));
    }
    
    [HttpPost]
    public async Task<ActionResult<ProductsInfo>> TopUpProducts(ProductsTopUpModel products, CancellationToken token) {
        return Ok(await _serviceService.TopUpProducts(products, token));
    }
    
}