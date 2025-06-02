using BrasilApiIntegration.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BrasilApiIntegration.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BanksController(IBankService bancoService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await bancoService.GetAll();
        return Ok(result);
    }

    [HttpGet("{bankCode}")]
    public async Task<IActionResult> GetBankByCode(string bankCode)
    {
        var result = await bancoService.GetBankByCode(bankCode);
        return Ok(result);
    }
}