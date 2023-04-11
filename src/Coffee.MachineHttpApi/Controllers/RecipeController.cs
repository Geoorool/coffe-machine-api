using MachineHttpApi.Models;
using MachineHttpApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MachineHttpApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : Controller
{
    private readonly IRecipeService _recipeService;
    
    public RecipeController(IRecipeService recipeService) {
        _recipeService = recipeService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Recipe>>> ListRecipes(CancellationToken token) {
        return Ok(await _recipeService.GetAll(token));
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Recipe>> Recipe(long id, CancellationToken token) {
        var result = await _recipeService.GetById(id, token);
        
        return result is null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<Recipe>> AddRecipe(RecipeCreationModel recipe, CancellationToken token) {
        return Ok(await _recipeService.Add(recipe, token));
    }

    [HttpPut]
    public async Task<ActionResult<Recipe>> ChangeRecipe(RecipeUpdateModel recipe, CancellationToken token) {
        var result = await _recipeService.Update(recipe, token);
        
        return result is null ? NotFound() : Ok(result);
    }

    [HttpDelete]
    public async Task<ActionResult<Recipe>> DeleteRecipe(long id, CancellationToken token) {
        var result = await _recipeService.Remove(id, token);
        
        return result is null ? NotFound() : Ok(result);
    }
}