using ForecastDesign.Models.ForWeather;
using ForecastDesign.Statics.StaticClasses.GetApiKeys;
using ForecastDesign.Statics.StaticClasses.GetImageClasses;
using ForecastDesign.Statics.StaticClasses.Maths;
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
        static DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
        public static async Task<WeatherData> GetWeatherDataAsync(string location)
        {
            using (var client = new HttpClient())
            {
                var api = GetApiKey.GetApiKeyString("ApiKeys", "WeatherApiKey");
                HttpResponseMessage response = await client
                .GetAsync($"http://api.openweathermap.org/data/2.5/forecast?q={location}&appid={(GetApiKey.GetApiKeyString("ApiKeys", "WeatherApiKey"))}&units=metric");
                try
                {

                response.EnsureSuccessStatusCode();
                }
                catch (Exception)
                {
                    return null;
                }
                var weather = JsonSerializer.Deserialize<WeatherData>(await response.Content.ReadAsStringAsync())!;
                GetWeeklyData(ref weather);
                weather!.ImageSourceCity = await GetImage.GetImageFromUnsplash((weather?.city?.country + "," + weather?.city?.name)!);
                weather!.city!.name = weather.city.country + " , " + weather!.city!.name;
                weather.SunRise = (UnixTimeStampToDateTime(weather.city.sunrise)).ToString("HH:mm");
                weather.SunSet = (UnixTimeStampToDateTime(weather.city.sunset)).ToString("HH:mm");
                return weather;
            }
        }
        private static  void GetWeeklyData(ref WeatherData weather)
        {
            List<ListItem> temp = new(weather?.list!);
            if (temp.Count > 7)
                temp.RemoveRange(7, temp.Count - 7);
            weather!.list = new();
            weather!.list = new(temp);
            int day = 0;
            foreach (var weekday in weather?.list!)
            {
                weekday.dt_txt = GetDayName.GetDayOfWeekString(DateTime.Now.AddDays(day++));
                weekday.weather![0].icon = $"http://openweathermap.org/img/w/{weekday.weather![0].icon}.png";
                weekday.main!.temp_max = ((int)weekday.main!.temp_max);
                weekday.main!.temp_min = ((int)weekday.main!.temp_min);
            }
        }
    }
}
