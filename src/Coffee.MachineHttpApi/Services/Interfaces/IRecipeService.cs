using MachineHttpApi.Models;

namespace MachineHttpApi.Services.Interfaces;

public interface IRecipeService
{
    Task<List<Recipe>> GetAll(CancellationToken token);

    Task<Recipe?> GetById(long id, CancellationToken token);

    Task<Recipe> Add(RecipeCreationModel recipe, CancellationToken token);

    Task<Recipe?> Update(RecipeUpdateModel recipe, CancellationToken token);

    Task<Recipe?> Remove(long id, CancellationToken token);
}