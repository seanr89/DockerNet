using Microsoft.AspNetCore.Mvc;
using DockerMinAPI.Models;

namespace DockerMinAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SettingsController : ControllerBase
{
    private readonly ILogger<SettingsController> _logger;
    private readonly BasicSettings _basicSettings;

    public SettingsController(ILogger<SettingsController> logger,
        IOptions<BasicSettings> basicSettings)
    {
        _logger = logger;
        _basicSettings = basicSettings.Value;
    }

    [HttpGet]
    public IActionResult Get(){
        return Ok();
    }

    // [HttpGet(Name = "GetWeatherForecast")]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateTime.Now.AddDays(index),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }
}
