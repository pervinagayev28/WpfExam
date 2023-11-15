using ForecastDesign.Commands;
using ForecastDesign.Services;
using ForecastDesign.Statics.StaticClasses.GetSmtpCode;
using ForecastDesign.Views.ViewPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    public class ViewModelConfirmation : ServiceINotifyPropertyChanged
    {
        private Visibility loadingVisibility;
        public Visibility LoadingVisibility { get => loadingVisibility; set { loadingVisibility = value; OnPropertyChanged(); } }
        public ICommand GoBackcommand { get; set; }
        public ICommand? Closecommand { get; set; }
        public ICommand? ConfirmCommand { get; set; }
        public string? Gmail { get; }
        public string VerifyCode { get; set; }

        public ViewModelConfirmation(string gmail)
        {
            LoadingVisibility = Visibility.Visible;
            Gmail = gmail;
            Thread loading =new(GetVerifyCode);
            loading.Start();
            GoBackcommand = new Command(ExecutGoBackcommand);
            Closecommand = new Command(ExecuteClosecommand);
            ConfirmCommand = new Command(ExecuteConfirmCommand, CanExecuteConfirmCommand);
        }
        private async void GetVerifyCode()
        {
            VerifyCode = await GetCode.GmailVerify(Gmail!);
            LoadingVisibility = Visibility.Hidden;
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
        private void ExecuteConfirmCommand(object obj)
        {
            var page = new ViewCreatPass();
            page.DataContext = new ViewModelCreatPass();
            ((Page)obj).NavigationService.Navigate(page);
        }

        private bool CanExecuteConfirmCommand(object obj)
        {
            if (VerifyCode == ((TextBox)((Page)obj).FindName("code")).Text.ToString()!)
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
