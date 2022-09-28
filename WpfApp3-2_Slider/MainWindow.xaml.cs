using System;
using System.Drawing;
using System.Windows;
using System.Windows.Media;

namespace WpfApp3_2_Slider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_R != null && _G != null && _B != null)
            {
                var r = new System.Windows.Media.SolidColorBrush();
                r.Color = System.Windows.Media.Color.FromRgb((byte)_R.Value, (byte)_G.Value, (byte)_B.Value);
                this.Background = r;
            }
        }
    }
}
