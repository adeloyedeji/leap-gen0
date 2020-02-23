using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiTutorials.Libs.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.Contract;

namespace DiTutorials.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IReverse<string> _reverse;
        private readonly IMovement _movement;
        private readonly IPelumi _pelumi;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IReverse<string> reverse, IMovement movement, IPelumi pelumi)
        {
            _logger = logger;
            _reverse = reverse;
            _movement = movement;
            _pelumi = pelumi;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var reversedString = _reverse.Reverse("abcdef");
            Console.WriteLine(reversedString);

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
