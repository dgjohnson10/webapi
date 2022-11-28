using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthCheckController : ControllerBase
{
    private readonly ILogger<HealthCheckController> _logger;

    public HealthCheckController(ILogger<HealthCheckController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetHealthCheck")]
    public HealthCheck Get()
    {
        return new HealthCheck()
        {
            Status = "Ok",
            Message = "Hello world"
        };
    }
}
