using Microsoft.Maps.MapControl.WPF;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ForecastDesign.Views.ViewPages
{
    
    public partial class ViewSearchLocationOnMap : Page
    {
        public ViewSearchLocationOnMap()
        {
            InitializeComponent();

        }

     

        private void changed(object sender, TextChangedEventArgs e)
        {
            map.ZoomLevel = 1;
        }
        
    }
}
