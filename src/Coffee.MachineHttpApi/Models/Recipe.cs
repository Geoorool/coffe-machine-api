namespace MachineHttpApi.Models;

public class Recipe
{
    public long Id { get; set; }

    public string Name { get; set; }

    public int MilkAmount { get; set; }

    public int SugarAmount { get; set; }
}