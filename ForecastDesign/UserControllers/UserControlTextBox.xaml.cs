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

namespace ForecastDesign.UserControllers
{
    public partial class UserControlTextBox : UserControl
    {
        public static readonly DependencyProperty NameeProperty =
                      DependencyProperty.Register("Text", typeof(string), typeof(UserControlTextBox));

        public string Text
        {
            get { return (string)GetValue(NameeProperty); }
            set { SetValue(NameeProperty, value); }
        }



        public static readonly DependencyProperty LbContentProperty =
                     DependencyProperty.Register("LbContent", typeof(string), typeof(UserControlTextBox));

        public string LbContent
        {
            get { return (string)GetValue(LbContentProperty); }
            set { SetValue(LbContentProperty, value); }
        }
        public UserControlTextBox()
        {
            InitializeComponent();
        }
    }
}
