using FinanceTracker.Api;
using FinanceTracker.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OperationsController : ControllerBase
{
    private readonly IOperationService _operationService;

    public OperationsController(IOperationService operationService)
    {
        _operationService = operationService;
    }

    [HttpGet]
    public async Task<IActionResult> GetOperations()
    {
        return Ok(await _operationService.GetAllOperationsAsync());
    }

    [HttpPost]
    public async Task<IActionResult> CreateOperation(Operation operation)
    {
        return Ok(await _operationService.CreateOperationAsync(operation));
    }
}