using ForecastDesign.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForecastDesign.Statics.StaticClasses.PullWeatherDataClasses
{
    public static class GetLocationCoordinat
    {
        public static async Task<Coord> Get(string location)
        {
            string locationName = location;
            string apiKey = "627a951f98f84eeeaa2d0b1f2972bcaa";

            string apiUrl = $"https://api.opencagedata.com/geocode/v1/json?q={locationName}&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                string jsonResult = await response.Content.ReadAsStringAsync();
                JObject resultObject = JObject.Parse(jsonResult);
                double latitude = (double)resultObject["results"]![0]!["geometry"]!["lat"]!;
                double longitude = (double)resultObject["results"]![0]!["geometry"]!["lng"]!;
                return new Coord() { lat = latitude, lon = longitude };

            }
        }
    }
}
