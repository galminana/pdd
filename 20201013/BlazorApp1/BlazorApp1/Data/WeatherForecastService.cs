using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecast[] GetForecastAsync(DateTime startDate)
        {

            WeatherForecast[] resultado = new WeatherForecast[10];
            resultado[0] = new WeatherForecast ();

            return resultado;
        }
    }
}
