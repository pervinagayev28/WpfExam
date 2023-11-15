using ForecastDesign.Commands;
using ForecastDesign.Models.Users;
using ForecastDesign.Services;
using ForecastDesign.Statics.StaticClasses.GetUser;
using ForecastDesign.Views.ViewPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    public  class ViewModeln:ServiceINotifyPropertyChanged
    {
        public ICommand? LogInCommand { get; set; }
        public ICommand? RegistrationCommand { get; set; }

        public ICommand? Closecommand { get; set; }
        public ViewModeln()
        {
            Closecommand = new Command(ExecuteClosecommand);
            LogInCommand = new Command(ExecuteLogInCommand, CanExecuteLogInCommand);
            RegistrationCommand = new Command(ExecuteRegistrationCommand);
            GetUsers.users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText("..//..//..//Database//JsonFiles//Users.json"));
        }

        private void ExecuteClosecommand(object obj)
        {
            if (obj is Page child)
            {
                DependencyObject parent = VisualTreeHelper.GetParent(child);

                while (parent != null && !(parent is NavigationWindow))
                    parent = VisualTreeHelper.GetParent(parent);
                if (parent != null)
                    (parent as NavigationWindow)!.Close();
            }
        }

      

        private void ExecuteRegistrationCommand(object obj)
        {

            var page = new ViewRegistration();
            page.DataContext = new ViewModelRegistration();
            ((Page)obj).NavigationService.Navigate(page);   
        }

        private bool CanExecuteLogInCommand(object obj) =>
            GetUsers.users?.Count != 0;

       
        private void ExecuteLogInCommand(object obj)
        {
            var page = new ViewLogIn();
            page.DataContext = new ViewModelLogin();
           ((Page)obj)!.NavigationService.Navigate(page);
        }

     
    }
}
