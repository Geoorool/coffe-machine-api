using MachineHttpApi.Models;
using MachineHttpApi.Services.Interfaces;

namespace MachineHttpApi.Services;

public class ServiceService : IServiceService
{
    private ProductsInfo _productsInfo = new() { CoffeeAmount = 1000, MilkAmount = 100, SugarAmount = 100 };

    public Task<ProductsInfo> Info(CancellationToken token) {
        return Task.FromResult(_productsInfo);
    }

    public Task<ProductsInfo> TopUpProducts(ProductsTopUpModel products, CancellationToken token) {
        _productsInfo.CoffeeAmount += products.CoffeeAmount;
        _productsInfo.MilkAmount += products.MilkAmount;
        _productsInfo.SugarAmount += products.SugarAmount;
        return Task.FromResult(_productsInfo);
    }
}