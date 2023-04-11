using MachineHttpApi.Models;

namespace MachineHttpApi.Services.Interfaces;

public interface IServiceService
{
    Task<ProductsInfo> Info(CancellationToken token);
    Task<ProductsInfo> TopUpProducts(ProductsTopUpModel products, CancellationToken token);
}