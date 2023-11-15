using ForecastDesign.Commands;
using ForecastDesign.Models.Users;
using ForecastDesign.Statics.StaticClasses.GetUser;
using ForecastDesign.Views.ViewPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    internal class ViewModelLogin
    {
        public ICommand? SignIncommand { get; set; }
        public ICommand GoBackcommand { get; set; }
        public ICommand? Closecommand { get; set; }
        public ViewModelLogin()
        {
            SignIncommand = new Command(ExecuteSignIncommand, CanExecuteSignIncommand);
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


        private bool CanExecuteSignIncommand(object obj)
        {
            if (GetUsers.users!.FirstOrDefault(u => u.Gmail == ((TextBox)((Page)obj).FindName("gmail")).Text.ToString()
                                                  && u.Password == ((TextBox)((Page)obj).FindName("password")).Text.ToString()) != null)
            {
                return true;
            }
            else
            {
                ((Label)((Page)obj).FindName("lb_error")).Visibility = Visibility.Visible;
                return false;
            }
        }

        private void ExecuteSignIncommand(object obj)
        {
            var page = new ViewEntry();
            page.DataContext = new ViewModelEntry(GetUsers.users!.FirstOrDefault(u => u.Gmail == ((TextBox)((Page)obj).FindName("gmail")).Text.ToString()
                                                  && u.Password == ((TextBox)((Page)obj).FindName("password")).Text.ToString())!.Location!);
            ((Page)obj).NavigationService.Navigate(page);
        }
    }
}
