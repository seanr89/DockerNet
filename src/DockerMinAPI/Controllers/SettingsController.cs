using Microsoft.AspNetCore.Mvc;
using DockerMinAPI.Models;
using Microsoft.Extensions.Options;

namespace DockerMinAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class SettingsController : ControllerBase
{
    private readonly ILogger<SettingsController> _logger;
    private readonly BasicSettings _basicSettings;
    private readonly string _connectionString;

    public SettingsController(ILogger<SettingsController> logger,
        IOptions<BasicSettings> basicSettings,
        IConfiguration config)
    {
        _logger = logger;
        _basicSettings = basicSettings.Value;
        _connectionString = config["ConnectionString"];
    }

    [HttpGet]
    public IActionResult Get(){
        return Ok(_basicSettings);
    }

    [HttpGet(Name = "GetConnectionSetting")]
    public IActionResult GetConnectionSetting()
    {
        _logger.LogInformation("GetConnectionSetting");
        return Ok(_connectionString);
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
