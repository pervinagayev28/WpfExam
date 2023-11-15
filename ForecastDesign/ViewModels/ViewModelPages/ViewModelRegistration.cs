using ForecastDesign.Commands;
using ForecastDesign.Models.Users;
using ForecastDesign.Statics.StaticClasses.GetSmtpCode;
using ForecastDesign.Statics.StaticClasses.GetUser;
using ForecastDesign.Views.ViewPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    internal class ViewModelRegistration
    {
        public ICommand GoBackcommand { get; set; }
        public ICommand? Closecommand { get; set; }
        public ICommand? SendCodeCommand { get; set; }
        public ViewModelRegistration()
        {
            GoBackcommand = new Command(ExecutGoBackcommand);
            Closecommand = new Command(ExecuteClosecommand);
            SendCodeCommand = new Command(ExecuteSendCodecommand, CanExecuteSendCodecommand);
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

        private bool CanExecuteSendCodecommand(object obj)
        {
            if (!string.IsNullOrWhiteSpace(((TextBox)((Page)obj).FindName("gmail")).Text.ToString()) &&
                       Regex.IsMatch(((TextBox)((Page)obj).FindName("gmail")).Text.ToString()!, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
            {
                ((Button)((Page)obj).FindName("btn")).Foreground = Brushes.Green;
                return true;
            }
            else
            {
                ((Button)((Page)obj).FindName("btn")).Foreground = Brushes.Gray;
                return false ;
            }

        }


        private void ExecuteSendCodecommand(object obj)
        {
            GetUsers.user!.Gmail = ((TextBox)((Page)obj).FindName("gmail")).Text.ToString();
            var page = new ViewConfirmationCode();
            page.DataContext = new ViewModelConfirmation(GetUsers.user!.Gmail);
            ((Page)obj)?.NavigationService.Navigate(page);
        }
    }
}
