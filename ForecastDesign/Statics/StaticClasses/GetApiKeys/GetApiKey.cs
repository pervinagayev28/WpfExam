using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastDesign.Statics.StaticClasses.GetApiKeys
{
    public static class GetApiKey
    {
        public static string GetApiKeyString(string Key, string Value)
        {
            var builder = new ConfigurationBuilder().
                AddJsonFile("C:\\Users\\user\\OneDrive\\Desktop\\ForecastDesign\\ForecastDesign\\appsettings.json");

            return builder.Build().GetSection(Key)[Value];
        }
    }
}
