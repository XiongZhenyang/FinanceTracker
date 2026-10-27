using FinanceTracker.Api;
using FinanceTracker.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
    private readonly IAccountService _accountService;
    public AccountsController(IAccountService accountService) { _accountService = accountService; }
    [HttpGet]
    public async Task<IActionResult> GetAccounts() { return Ok(await _accountService.GetAllAccountsAsync()); }
    [HttpPost]
    public async Task<IActionResult> CreateAccount(Account account) { return Ok(await _accountService.CreateAccountAsync(account)); }
}
