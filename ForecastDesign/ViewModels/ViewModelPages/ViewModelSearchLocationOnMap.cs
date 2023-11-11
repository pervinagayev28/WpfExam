using ForecastDesign.Commands;
using ForecastDesign.Models;
using ForecastDesign.Models.ForWeather;
using ForecastDesign.Services;
using ForecastDesign.Statics.StaticClasses.GetApiKeys;
using ForecastDesign.Statics.StaticClasses.PullWeatherDataClasses;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    public class ViewModelSearchLocationOnMap : ServiceINotifyPropertyChanged
    {
        public static WeatherData test { get; set; }
        private WeatherData? Weather;
        private CredentialsProvider? credentialProvider;

        public WeatherData? weatherr { get => Weather; set { Weather = value; OnPropertyChanged(); } }
        public CredentialsProvider? CredentialProvider { get => credentialProvider; set { credentialProvider = value; OnPropertyChanged(); } }
        public ICommand? GoBackCommand { get; set; }
        public ICommand? EarthModeCommmand { get; set; }
        public ICommand? AerialModeCommmand { get; set; }
        public ICommand? AerialWithLabelsModeCommmand { get; set; }
        public ICommand? SearchCommmand { get; set; }
        public ViewModelSearchLocationOnMap()
        {
            CredentialProvider = new ApplicationIdCredentialsProvider(GetApiKey.GetApiKeyString("ApiKeys", "MapApiKey")); ;
            GoBackCommand = new Command(ExecuteGoBackCommand);
            EarthModeCommmand = new Command(ExecuteEarthModeCommmand, CanExecuteEarthModeCommmand);
            AerialModeCommmand = new Command(ExecuteAerialModeCommmand, CanExecuteAerialModeCommmand);
            AerialWithLabelsModeCommmand = new Command(ExecuteAerialWithLabelsModeCommmand, CanExecuteAerialWithLabelsModeCommmand);
            SearchCommmand = new Command(ExecuteSearchCommmand, CanExecuteSearchCommmand);
        }
        private bool CanExecuteSearchCommmand(object obj) =>
      !string.IsNullOrEmpty(((TextBox)((Page)obj).FindName("textbox")).Text);
        private void ExecuteSearchCommmand(object obj)
        {
            var map = ((Map)((Page)obj).FindName("map"));
            string text = ((TextBox)((Page)obj).FindName("textbox")).Text.ToString();
            GetDataAsync(text,map);
        }
        private async void GetDataAsync(string location, Map map)
        {
            Coord data = await GetLocationCoordinat.Get(location);
            map.Center = new Location(data.lat,data.lon);
            map.CredentialsProvider = credentialProvider;
            map.ZoomLevel = 10;
        //    weatherr = new();
        //    weatherr = await GetWeatherData.GetWeatherDataAsync(location)!;
        //    test = weatherr;
        //    if (weatherr == null)
        //    {
        //        MessageBox.Show("not found location");
        //        weatherr = await GetWeatherData.GetWeatherDataAsync("baku")!;
        //    }
        }

        private bool CanExecuteAerialWithLabelsModeCommmand(object obj) =>
             ((Map)((Page)obj).FindName("map")).Mode != new AerialMode(true);


        private void ExecuteAerialWithLabelsModeCommmand(object obj) =>
               ((Map)((Page)obj).FindName("map")).Mode = new AerialMode(true);


        private bool CanExecuteAerialModeCommmand(object obj) =>
             ((Map)((Page)obj).FindName("map")).Mode != new AerialMode();


        private void ExecuteAerialModeCommmand(object obj) =>
              ((Map)((Page)obj).FindName("map")).Mode = new AerialMode();


        private bool CanExecuteEarthModeCommmand(object obj) =>
            ((Map)((Page)obj).FindName("map")).Mode != new RoadMode();

        private void ExecuteEarthModeCommmand(object obj) =>
            ((Map)((Page)obj).FindName("map")).Mode = new RoadMode();


        private void ExecuteGoBackCommand(object obj) =>
        ((Page)obj).NavigationService.GoBack();

    }
}
