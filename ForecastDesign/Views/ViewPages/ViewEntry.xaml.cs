﻿using ForecastDesign.ViewModels.ViewModelPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ForecastDesign.Views.ViewPages
{
    public partial class ViewEntry : Page
    {

     
        public ViewEntry()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_search.Command.Execute(combobox.SelectedValue.ToString());
        }
    }
}
