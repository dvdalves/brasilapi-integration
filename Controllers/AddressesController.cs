using BrasilApiIntegration.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BrasilApiIntegration.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AddressesController(IAddressService addressService) : ControllerBase
{
    [HttpGet("search/{cep}")]
    public async Task<IActionResult> GetAddressByCep([FromRoute] string cep)
    {
        var response = await addressService.GetAddressByCep(cep);
        if (response.HttpStatus == HttpStatusCode.OK)
            return Ok(response.ReturnData);
        else
            return StatusCode((int)response.HttpStatus, response.ErrorDetails);
    }
}