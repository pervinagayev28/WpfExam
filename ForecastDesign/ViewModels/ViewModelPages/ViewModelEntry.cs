using ForecastDesign.Models.ForWeather;
using ForecastDesign.Models.Maths;
using ForecastDesign.Services;
using ForecastDesign.Statics.StaticClasses.GetImageClasses;
using ForecastDesign.Statics.StaticClasses.PullWeatherDataClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    public class ViewModelEntry : ServiceINotifyPropertyChanged
    {
        public string CurrentTime { get => currentTime; set { currentTime = value; OnPropertyChanged(); } }
        private WeatherData? Weather;
        private string currentTime;

        public WeatherData? weather { get => Weather; set { Weather = value; OnPropertyChanged(); } }
        #region Timer

        public void Timer()
        {
            var timer = new Timer(60000); 
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
            CurrentTime = DateTime.Now.ToString("HH:mm");
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            CurrentTime = DateTime.Now.ToString("HH:mm");
        }
        #endregion
        private async void GetDataAsync(string location)
        {
            weather = await GetWeatherData.GetWeatherDataAsync(location)!;
            weather.ImageSource = await GetImage.GetImageFromUnsplash((weather?.list![0].weather![0].main + " weather photo")!);
            weather!.ImageSourceCity = await GetImage.GetImageFromUnsplash((weather?.city?.country + "," + weather?.city?.name + " photo")!);
            weather!.list![0].dt_txt = GetDayName.GetDayOfWeekString(DateTime.Now);
            weather!.city!.name = weather.city.country + " , " + weather!.city!.name;
        }
        public ViewModelEntry()
        {
            Timer();

            GetDataAsync("azerbaijan");

        }
    }
}
