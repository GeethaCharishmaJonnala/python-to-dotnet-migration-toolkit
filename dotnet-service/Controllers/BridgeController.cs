using Microsoft.AspNetCore.Mvc;
using dotnet_service.Services;

namespace dotnet_service.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BridgeController : ControllerBase
{
    private readonly PythonServiceClient _pythonService;
    private readonly ILogger<BridgeController> _logger;

    public BridgeController(
        PythonServiceClient pythonService,
        ILogger<BridgeController> logger)
    {
        _pythonService = pythonService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        _logger.LogInformation("Calling Python service");

        var result = await _pythonService.GetPythonData();

        return Ok(result);
    }
}