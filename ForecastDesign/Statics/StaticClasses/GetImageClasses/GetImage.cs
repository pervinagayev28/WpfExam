using ForecastDesign.Statics.StaticClasses.GetApiKeys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ForecastDesign.Statics.StaticClasses.GetImageClasses
{
    public static class GetImage
    {
        public static async Task<BitmapImage> GetImageFromUnsplash(string searchQuery)
        {
            using (var httpClient = new HttpClient())
            {
                string unsplashUrl = $"https://api.unsplash.com/photos/random?query={searchQuery}&client_id={(GetApiKey.GetApiKeyString("ApiKeys", "ImageApiKey"))}";
                HttpResponseMessage unsplashResponse = await httpClient.GetAsync(unsplashUrl);
                string imageUrl = ((JsonDocument.Parse(await unsplashResponse.Content.ReadAsStringAsync())).RootElement).GetProperty("urls").GetProperty("regular").GetString()!;
                return new BitmapImage(new Uri(imageUrl!, UriKind.Absolute));
            }
        }
    }
}
