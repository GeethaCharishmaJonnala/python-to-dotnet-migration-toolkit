using Microsoft.AspNetCore.Mvc;
using dotnet_service.Services;

namespace dotnet_service.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BridgeController : ControllerBase
{
    private readonly PythonServiceClient _pythonService;

    public BridgeController(PythonServiceClient pythonService)
    {
        _pythonService = pythonService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _pythonService.GetPythonData();

        return Ok(result);
    }
}