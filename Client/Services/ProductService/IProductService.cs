using BlazorEcom.Shared;

namespace BlazorEcom.Client.Services.ProductService;

public interface IProductService
{
    List<Product> Products { get; set; }

    Task GetProducts();
}