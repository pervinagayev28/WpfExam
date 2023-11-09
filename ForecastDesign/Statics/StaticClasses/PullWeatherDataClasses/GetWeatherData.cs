using ForecastDesign.Models.ForWeather;
using ForecastDesign.Statics.StaticClasses.GetApiKeys;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace ForecastDesign.Statics.StaticClasses.PullWeatherDataClasses
{
    static public class GetWeatherData
    {

        public static async Task<WeatherData> GetWeatherDataAsync(string location)
        {
            using (var client = new HttpClient())
            {
                var api = GetApiKey.GetApiKeyString("ApiKeys", "WeatherApiKey");
                HttpResponseMessage response = await client
                .GetAsync($"http://api.openweathermap.org/data/2.5/forecast?q={location}&appid={(GetApiKey.GetApiKeyString("ApiKeys", "WeatherApiKey"))}&units=metric");
                response.EnsureSuccessStatusCode();
                return JsonSerializer.Deserialize<WeatherData>(await response.Content.ReadAsStringAsync())!;
            }
        }
    }
}
