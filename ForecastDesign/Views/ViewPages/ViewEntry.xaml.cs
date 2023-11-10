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

        public static readonly DependencyProperty HeaderProperty =
               DependencyProperty.Register("foo", typeof(string), typeof(ViewEntry));

        public string foo
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }
        public ViewEntry()
        {
            InitializeComponent();
            DataContext = new ViewModelEntry();
        }

     
    }
}
