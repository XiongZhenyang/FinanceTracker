using FinanceTracker.Api;
using FinanceTracker.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCategories()
    {
        return Ok(await _categoryService.GetAllCategoriesAsync());
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory(Category category)
    {
        return Ok(await _categoryService.CreateCategoryAsync(category));
    }
}