using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    // Hard-coded list of categories for demo
    private static readonly string[] Categories = new[]
    {
        "Food", "Transport", "Entertainment", "Salary", "Rent", "Utilities"
    };

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return Ok(Categories);
    }

    [HttpGet("{id}")]
    public ActionResult<string> GetById(int id)
    {
        if (id < 1 || id > Categories.Length)
        {
            return NotFound();
        }
        return Ok(Categories[id - 1]);
    }
}
