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
    /// <summary>
    /// Interaction logic for UserControlButtonStyle.xaml
    /// </summary>
    public partial class UserControlButtonStyle : UserControl
    {
        public static readonly DependencyProperty CommandProperty =
                     DependencyProperty.Register("command", typeof(ICommand), typeof(UserControlButtonStyle));

        public ICommand command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty CommandParamProperty =
                     DependencyProperty.Register("CommandParam", typeof(object), typeof(UserControlButtonStyle));

        public object CommandParam
        {
            get { return (object)GetValue(CommandParamProperty); }
            set { SetValue(CommandParamProperty, value); }
        }

        public static readonly DependencyProperty IconKindProperty =
                      DependencyProperty.Register("IconKind", typeof(string), typeof(UserControlButtonStyle));

        public string IconKind
        {
            get { return (string)GetValue(IconKindProperty); }
            set { SetValue(IconKindProperty, value); }
        }
        public UserControlButtonStyle()
        {
            InitializeComponent();
        }

      
    }
}
