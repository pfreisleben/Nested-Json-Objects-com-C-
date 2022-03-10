using System;
using System.ComponentModel.DataAnnotations;

namespace webapiTeste
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "É necessário informar algum valor")]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string Summary { get; set; }

        public Teste? Teste { get; set; }
    }

    public  class Teste
    {
        public int? Teste1 { get; set; }

        public int Teste2 { get; set; }
    }
}
