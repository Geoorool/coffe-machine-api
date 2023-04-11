namespace MachineHttpApi.Models;

public record RecipeUpdateModel(long Id, string Name, int MilkAmount, int SugarAmount);