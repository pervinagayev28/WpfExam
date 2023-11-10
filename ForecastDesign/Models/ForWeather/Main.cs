using ForecastDesign.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastDesign.Models.ForWeather
{
    public class Main:ServiceINotifyPropertyChanged
    {
        private float temp_min1;
        private float temp_max1;
        private float temp1;

        public float temp { get => temp1; set { temp1 = value; OnPropertyChanged(); } }
        public float feels_like { get; set; }
        public float temp_min { get => temp_min1; set { temp_min1 = value;OnPropertyChanged();} }
        public float temp_max { get => temp_max1; set { temp_max1 = value; OnPropertyChanged(); } }
        public int pressure { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
        public int humidity { get; set; }
        public float temp_kf { get; set; }
    }
}
