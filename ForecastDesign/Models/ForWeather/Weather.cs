﻿using ForecastDesign.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastDesign.Models.ForWeather
{
    public class Weather:ServiceINotifyPropertyChanged
    {
        private string? icon1;

        public int id { get; set; }
        public string? main { get; set; }
        public string? description { get; set; }
        public string? icon { get => icon1; set { icon1 = value;OnPropertyChanged(); } }
    }
}
