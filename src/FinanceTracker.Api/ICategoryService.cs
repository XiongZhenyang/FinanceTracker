using FinanceTracker.Domain;

namespace FinanceTracker.Api;

public interface ICategoryService
{
    Task<List<Category>> GetAllCategoriesAsync();
    Task<Category> CreateCategoryAsync(Category category);
}