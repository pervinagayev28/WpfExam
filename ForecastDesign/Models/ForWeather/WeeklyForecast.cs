using ForecastDesign.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastDesign.Models.ForWeather
{
    public class ListItem:ServiceINotifyPropertyChanged
    {
        private string? dt_txt1;

        public int ?dt { get; set; }
        public Main ?main { get; set; }
        public List<Weather>? weather { get; set; }
        public Clouds? clouds { get; set; }
        public Wind? wind { get; set; }
        public int? visibility { get; set; }
        public float? pop { get; set; }
        public Sys? sys { get; set; }
        public string? dt_txt { get => dt_txt1; set {dt_txt1 = value;OnPropertyChanged(); }
    }
    }
}
