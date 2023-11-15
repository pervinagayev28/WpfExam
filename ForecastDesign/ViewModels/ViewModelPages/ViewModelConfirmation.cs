using ForecastDesign.Commands;
using ForecastDesign.Statics.StaticClasses.GetSmtpCode;
using ForecastDesign.Views.ViewPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ForecastDesign.ViewModels.ViewModelPages
{
    public  class ViewModelConfirmation
    {
        public ICommand ?ConfirmCommand { get; set; }
        public string? Gmail { get; }

        public ViewModelConfirmation(string gmail)
        {
            ConfirmCommand = new Command(ExecuteConfirmCommand, CanExecuteConfirmCommand);
            Gmail = gmail;
        }

        private void ExecuteConfirmCommand(object obj)
        {
            var page = new ViewCreatPass();
            page.DataContext = new ViewModelCreatPass();
            ((Page)obj).NavigationService.Navigate(page);
        }

        private bool CanExecuteConfirmCommand(object obj) =>
            GetCode.GmailVerify(Gmail!)== ((TextBox)((Page)obj).FindName("textbox")).Text.ToString()!;
    }
}
