using System;

namespace webapiTeste
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

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
