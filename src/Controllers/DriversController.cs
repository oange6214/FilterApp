using Microsoft.AspNetCore.Mvc;
using src.Configurations.Filters;

namespace FilterApp.Controllers;

[ApiController]
[Route("[controller]")]
[MyActionFilter("DriversController")]
public class DriversController : ControllerBase
{
    private static List<string> _drivers = new()
    {
        "Lewis Hamilton",
        "George Russel",
        "Valteri Bottas",
        "Carlos Sains",
        "Arton Sena"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public DriversController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetDrivers")]
    [MyActionFilter("GetDriver-Action")]
    [MyAsyncActionFilter("GetDriverAsync", 10)]
    [MySecondAsyncActionFilter("GetDriverAsync 2")]
    public IActionResult Get()
    {
        return Ok(_drivers);
    }

    [HttpPost(Name = "AddDrvier")]
    public IActionResult Post(string driverName)
    {
        _drivers.Add(driverName);
        return Ok(_drivers);
    }

}
