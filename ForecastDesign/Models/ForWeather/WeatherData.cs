using ForecastDesign.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ForecastDesign.Models.ForWeather
{
    public class WeatherData:ServiceINotifyPropertyChanged
    {
        private ImageSource? imageSource;
        private ImageSource? imageSourceCity;
        public string? cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public List<ListItem> ?list { get; set; }
        public City ?city { get; set; }
        public ImageSource? ImageSource { get => imageSource; set {imageSource = value; OnPropertyChanged(); } }
        public ImageSource ImageSourceCity { get => imageSourceCity; set { imageSourceCity = value; OnPropertyChanged(); } }
    }
}
