using ForecastDesign.Commands;
using ForecastDesign.Models.ForWeather;
using ForecastDesign.Services;
using ForecastDesign.Statics.StaticClasses.GetImageClasses;
using ForecastDesign.Statics.StaticClasses.Maths;
using ForecastDesign.Statics.StaticClasses.PullWeatherDataClasses;
using ForecastDesign.Views.ViewPages;
using MaterialDesignThemes.Wpf;
using Microsoft.Maps.MapControl.WPF;
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
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    public class ViewModelEntry : ServiceINotifyPropertyChanged
    {
        public string CurrentTime { get => currentTime; set { currentTime = value; OnPropertyChanged(); } }
        private string currentTime;
        private WeatherData? Weather;
        public WeatherData? weather { get => Weather; set { Weather = value; OnPropertyChanged(); } }

        public ICommand? ClosedCommand { get; set; }
        public ICommand? FahrenHeitCommand { get; set; }
        public ICommand? CelciCommand { get; set; }
        public ICommand? SearchCommand { get; set; }
        public ICommand? MapCommand { get; set; }

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
        #region GetWeatherData
        private async void GetDataAsync(string location)
        {
            weather = await GetWeatherData.GetWeatherDataAsync(location)!;
            if (weather == null)
            {
                MessageBox.Show("not found location");
                weather = await GetWeatherData.GetWeatherDataAsync("baku")!;
            }
        }
        #endregion
        public ViewModelEntry()
        {

            //Timer();
            //GetDataAsync("Xirdalan");
            ClosedCommand = new Command(ExecuteCloseCommand);
            FahrenHeitCommand = new Command(ExecuteFahrenHeitCommandCommand);
            CelciCommand = new Command(ExecuteCelciCommand);
            SearchCommand = new Command(ExecuteSearchCommand, CanExecuteSearchCommand);
            MapCommand = new Command(ExecuteMapCommand);

        }

        private void ExecuteMapCommand(object obj)
        {
            Page ViewMap =new ViewSearchLocationOnMap();
            ViewMap.DataContext = new ViewModelSearchLocationOnMap();
            ((Page)obj).NavigationService.Navigate(ViewMap);
        }

        private bool CanExecuteSearchCommand(object obj)=>
            !string.IsNullOrEmpty(obj.ToString());

        private void ExecuteSearchCommand(object obj)
        {
            GetDataAsync(obj.ToString()!);
        }

        private void ExecuteCelciCommand(object obj)
        {
            Button? btn_f = (Button)((StackPanel)obj).FindName("F");
            Button? btn_c = (Button)((StackPanel)obj).FindName("C");
            btn_c.Background = Brushes.White;
            btn_f.Background = Brushes.Black;
            btn_c.Foreground = Brushes.Black;
            btn_f.Foreground = Brushes.White;
            weather!.kindTemp = "TemperatureCelsius";
            weather!.list![0]!.main!.temp = ConverterTemrature.ConvertToCelsius(weather.list![0]!.main!.temp);
        }

        private void ExecuteFahrenHeitCommandCommand(object obj)
        {
            Button? btn_f = (Button)((StackPanel)obj).FindName("F");
            Button? btn_c = (Button)((StackPanel)obj).FindName("C");
            btn_f.Background = Brushes.White;
            btn_c.Background = Brushes.Black;
            btn_f.Foreground = Brushes.Black;
            btn_c.Foreground = Brushes.White;
            weather!.kindTemp = "TemperatureFahrenheit";
            weather!.list![0]!.main!.temp = ConverterTemrature.ConvertToFarenheit(weather.list![0]!.main!.temp);
        }

        private void ExecuteCloseCommand(object? param)
        {
            if (param is Page child)
            {
                DependencyObject parent = VisualTreeHelper.GetParent(child);

                while (parent != null && !(parent is NavigationWindow))
                    parent = VisualTreeHelper.GetParent(parent);
                if (parent != null)
                    (parent as NavigationWindow)!.Close();
            }
        }

    }
}
