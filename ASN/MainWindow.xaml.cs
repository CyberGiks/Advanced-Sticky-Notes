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

namespace ASN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isOnTop = false;
        bool ctrlPressed = false;
        public MainWindow()
        {
            InitializeComponent();
            btn_pin.DeActivate();
        }

        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                if (WindowState == WindowState.Normal)
                {
                    WindowState = WindowState.Maximized;
                }
                else
                {
                    WindowState = WindowState.Normal;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }

        private void toggleTop_Click(object sender, RoutedEventArgs e)
        {
            if (!isOnTop)
            {
                isOnTop = true;
                this.Topmost = true;
                btn_pin.Activate();
            }
            else
            {
                isOnTop = false;
                this.Topmost = false;
                btn_pin.DeActivate();
            }
        }

        private void rich_txtbox_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (!ctrlPressed)
                return;
            var scroll = e.Delta;
            if (scroll > 0)
            {
                rich_txtbox.FontSize++;
            }
            else
            {
                if (rich_txtbox.FontSize > 5)
                    rich_txtbox.FontSize--;
            }
        }

        private void rich_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
                ctrlPressed = true;

        }

        private void rich_txtbox_KeyUp(object sender, KeyEventArgs e)
        {
            ctrlPressed = false;
        }
    }
}
