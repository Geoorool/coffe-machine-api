using Microsoft.AspNetCore.Mvc;

namespace MachineHttpApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : Controller
{
    [HttpGet]
    public IActionResult ListRecipes() {
        var recipes = new[] {
            new { Id = 1, Name = "Cappuccino", Milk = 3, Sugar = 5 },
            new { Id = 2, Name = "Late", Milk = 5, Sugar = 5 }
        };
        return Ok(recipes);
    }
    
    [HttpGet("{id}")]
    public IActionResult Recipe(int id) {
        var recipe = new { Id = 2, Name = "Late", Milk = 5, Sugar = 5 };
        return Ok(recipe);
    }

    [HttpPost]
    public IActionResult AddRecipe() {
        return Ok(true);
    }

    [HttpPut]
    public IActionResult ChangeRecipe() {
        var changedRecipe = new { Id = 1, Name = "Cappuccino", Milk = 3, Sugar = 5 };
        return Ok(changedRecipe);
    }

    [HttpDelete]
    public IActionResult DeleteRecipe() {
        return Ok(true);
    }
}