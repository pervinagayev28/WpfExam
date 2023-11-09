using ForecastDesign.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastDesign.Models.ForWeather
{
    public class City:ServiceINotifyPropertyChanged
    {
        private string name1;
        public string name { get => name1; set { name1 = value;OnPropertyChanged(); } }

        public int id { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
        public int timezone { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
}
