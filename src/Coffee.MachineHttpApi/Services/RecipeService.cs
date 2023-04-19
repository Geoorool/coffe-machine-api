using MachineHttpApi.Models;
using MachineHttpApi.Services.Interfaces;

namespace MachineHttpApi.Services;

public class RecipeService : IRecipeService
{
    private List<Recipe> _recipes = new(){
        new Recipe { Id = 1, Name = "Cappuccino", MilkAmount = 3, SugarAmount = 5 },
        new Recipe { Id = 2, Name = "Late", MilkAmount = 5, SugarAmount = 5 }
    };
    public Task<List<Recipe>> GetAll(CancellationToken _) {
        return Task.FromResult(_recipes);
    }

    public Task<Recipe?> GetById(long id, CancellationToken _) {
        var recipe = _recipes.SingleOrDefault(r => r.Id == id);
        return Task.FromResult(recipe);
    }

    public Task<Recipe> Add(RecipeCreationModel recipe, CancellationToken _) {
        var recipeId = _recipes.Count == 0 ? 1 : _recipes.Max(r => r.Id) + 1;
        var newRecipe = new Recipe {
            Id = recipeId,
            Name = recipe.Name,
            MilkAmount = recipe.MilkAmount,
            SugarAmount = recipe.SugarAmount
        };
        _recipes.Add(newRecipe);
        return Task.FromResult(newRecipe);
    }

    public Task<Recipe?> Update(RecipeUpdateModel recipe, CancellationToken _) {
        var recipeForUpdate = _recipes.SingleOrDefault(r => r.Id == recipe.Id);
        if (recipeForUpdate is null) {
            return Task.FromResult<Recipe?>(null);
        }

        recipeForUpdate.Name = recipe.Name;
        recipeForUpdate.MilkAmount = recipe.MilkAmount;
        recipeForUpdate.SugarAmount = recipe.SugarAmount;

        return Task.FromResult(recipeForUpdate);
    }

    public Task<Recipe?> Remove(long id, CancellationToken _) {
        var deletedRecipe = _recipes.SingleOrDefault(r => r.Id == id);
        if (deletedRecipe is null) {
            return Task.FromResult<Recipe?>(null);
        }

        _recipes.Remove(deletedRecipe);
        return Task.FromResult(deletedRecipe);
    }
}