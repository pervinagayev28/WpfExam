using ForecastDesign.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ForecastDesign.Models.ForWeather
{
    public class WeatherData:ServiceINotifyPropertyChanged
    {
        private ImageSource? imageSourceCity;
        private ObservableCollection<ListItem>? list1;
        private string ?kindTemp1= "TemperatureCelsius";

        public string kindTemp { get => kindTemp1; set { kindTemp1 = value;OnPropertyChanged(); } }
        public string? cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public ObservableCollection<ListItem>? list { get => list1; set { list1 = value; OnPropertyChanged(); } }
        public City ?city { get; set; }
        public ImageSource ImageSourceCity { get => imageSourceCity!; set { imageSourceCity = value; OnPropertyChanged(); } }
        public string SunRise { get; set; }
        public string SunSet { get; set; }
    }
}
