using Microsoft.AspNetCore.Mvc;

namespace TaxReport.Api.Controllers;

[ApiController]
[Route("operations")]
public class OperationController : ControllerBase
{
    private readonly ILogger<OperationController> _logger;

    public OperationController(ILogger<OperationController> logger)
    {
        _logger = logger;
    }

    [HttpPost("files/upload/b3")]
    public async Task<IActionResult> UploadAsync(IFormFile file)
    {
        return NoContent();
    }
}
