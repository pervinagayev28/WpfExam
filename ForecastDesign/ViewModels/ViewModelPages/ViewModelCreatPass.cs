using ForecastDesign.Commands;
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
    public class ViewModelCreatPass
    {
        public ICommand ?SignInCommand{ get; set; }
        public ViewModelCreatPass()
        {
            SignInCommand = new Command(ExecuteSignInCommand, CanExecuteSignInCommand);
        }

        private void ExecuteSignInCommand(object obj)
        {
            var page = new ViewEntry();
            page.DataContext = new ViewModelEntry(((TextBox)((Page)obj).FindName("textbox_location")).Text.ToString());
            ((Page)obj).NavigationService.Navigate(page);
        }

        private bool CanExecuteSignInCommand(object obj)=>
             !string.IsNullOrWhiteSpace(((TextBox)((Page)obj).FindName("textbox_location")).Text.ToString()) 
            && Regex.IsMatch(((TextBox)((Page)obj).FindName("textbox_password")).Text.ToString()!, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
    }
}
