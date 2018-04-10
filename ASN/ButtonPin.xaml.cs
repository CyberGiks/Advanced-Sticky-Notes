using System.Windows;
using System.Windows.Controls;

namespace ASN
{
    /// <summary>
    /// Interaction logic for ButtonPin.xaml
    /// </summary>
    public partial class ButtonPin : UserControl
    {

        public ButtonPin()
        {
            InitializeComponent();
            DeActivate();
        }

        public void Activate()
        {
            img_blue_pin.Visibility = Visibility.Visible;
            img_white_pin.Visibility = Visibility.Hidden;
        }

        public void DeActivate()
        {
            img_blue_pin.Visibility = Visibility.Hidden;
            img_white_pin.Visibility = Visibility.Visible;
        }
    }
}
