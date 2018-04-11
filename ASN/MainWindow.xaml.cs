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

        public MainWindow()
        {
            InitializeComponent();
            btn_pin.DeActivate();
            rich_txtbox.AllowDrop = true;
        }

        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                if(WindowState == WindowState.Normal)
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
    }
}
