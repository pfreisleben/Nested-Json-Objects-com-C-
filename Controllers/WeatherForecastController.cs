using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapiTeste.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("teste")]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogInformation("Entrou no método get");
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                Teste = new Teste { Teste1 = 2, Teste2 = 3}
            })
            .ToArray();
        }
        [HttpPost("teste")]
        public WeatherForecast Post([FromBody] WeatherForecast weather)
        {
            _logger.LogInformation("Entrou no método post");
            Console.WriteLine(weather.Teste.Teste1);
            return weather;
            
        }
        [HttpPost("serialize")]
        public WeatherForecast Serialize([FromBody] dynamic weather)
        {
            weather = weather.ToString();

           _logger.LogInformation($"Novo objeto enviado: {weather}");
            WeatherForecast teste = JsonSerializer.Deserialize<WeatherForecast>(weather);
            Console.WriteLine(teste.Date);
            return teste;

        }
    }
}
