using ForecastDesign.Commands;
using ForecastDesign.Models;
using ForecastDesign.Models.ForWeather;
using ForecastDesign.Services;
using ForecastDesign.Statics.StaticClasses.GetApiKeys;
using ForecastDesign.Statics.StaticClasses.PullWeatherDataClasses;
using ForecastDesign.UserControllers;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    public class ViewModelSearchLocationOnMap : ServiceINotifyPropertyChanged
    {
        private WeatherData? Weather;
        private CredentialsProvider? credentialProvider;

        public WeatherData? weather { get => Weather; set { Weather = value; OnPropertyChanged(); } }
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
            weather = await GetWeatherData.GetWeatherDataAsync(location)!;
            map.Children.Clear();
            
            Coord data = await GetLocationCoordinat.Get(location);
            map.Center = new Location(weather.city!.coord.lat, weather.city.coord.lon);
            map.ZoomLevel = 10;
            map.Children.Add(new Pushpin()
            {
                Location = new Location(data.lat, data.lon),
            });
            ToolTipService.SetToolTip(((Pushpin)map.Children[map.Children.Count - 1]), new UserControlMapContent());
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
