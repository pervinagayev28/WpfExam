using ForecastDesign.Commands;
using ForecastDesign.Statics.StaticClasses.GetUser;
using ForecastDesign.Views.ViewPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    public class ViewModelCreatPass
    {
        public ICommand? SignInCommand { get; set; }
        public ICommand GoBackcommand { get; set; }
        public ICommand? Closecommand { get; set; }
        public ViewModelCreatPass()
        {
            SignInCommand = new Command(ExecuteSignInCommand, CanExecuteSignInCommand);
            GoBackcommand = new Command(ExecutGoBackcommand);
            Closecommand = new Command(ExecuteClosecommand);
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

        private void ExecutGoBackcommand(object obj) =>
           ((Page)obj).NavigationService.GoBack();
        private void ExecuteSignInCommand(object obj)
        {
            GetUsers.user!.Password = ((TextBox)((Page)obj).FindName("password")).Text.ToString();
            GetUsers.user!.Location = ((TextBox)((Page)obj).FindName("location")).Text.ToString();
            var page = new ViewEntry();
            page.DataContext = new ViewModelEntry(GetUsers.user.Location);
            GetUsers.users!.Add(GetUsers.user);
            File.WriteAllText(@"..\..\..\Database\JsonFiles\Users.json", JsonSerializer.Serialize(GetUsers.users, new JsonSerializerOptions() { WriteIndented = true }));
            GetUsers.user = new();
            ((Page)obj).NavigationService.Navigate(page);
        }

        private bool CanExecuteSignInCommand(object obj)
        {
            if (!string.IsNullOrWhiteSpace(((TextBox)((Page)obj).FindName("location")).Text.ToString())
            && Regex.IsMatch(((TextBox)((Page)obj).FindName("password")).Text.ToString()!, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
            {
                ((Button)((Page)obj).FindName("btn")).Foreground = Brushes.Green;
                return true;
            }
            else
            {
                ((Button)((Page)obj).FindName("btn")).Foreground = Brushes.Gray;
                return false;
            }

        }
    }
}
