using BlazorEcom.Shared;

namespace BlazorEcom.Client.Services.CategoryService;

public interface ICategoryService
{
    List<Category> Categories { get; set; }
    Task GetCategories();
}