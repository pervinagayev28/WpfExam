using ForecastDesign.Commands;
using ForecastDesign.Models.Users;
using ForecastDesign.Statics.StaticClasses.GetSmtpCode;
using ForecastDesign.Views.ViewPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    internal class ViewModelRegistration
    {
        public ICommand? SendCodeCommand { get; set; }
        public ViewModelRegistration()
        {
            SendCodeCommand = new Command(ExecuteSendCodecommand, CanExecuteSendCodecommand);
        }

        private bool CanExecuteSendCodecommand(object obj) =>
            !string.IsNullOrWhiteSpace(((TextBox)((Page)obj).FindName("textbox")).Text.ToString()) &&
                       Regex.IsMatch(((TextBox)((Page)obj).FindName("textbox")).Text.ToString()!, @"^[a-zA-Z0-9._%+-]+@gmail\.com$");
     

        private void ExecuteSendCodecommand(object obj)
        {
            var page = new ViewConfirmationCode();
            page.DataContext = new ViewModelConfirmation(((TextBox)((Page)obj).FindName("textbox")).Text.ToString());
            ((Page)obj)?.NavigationService.Navigate(page);
        }
    }
}
