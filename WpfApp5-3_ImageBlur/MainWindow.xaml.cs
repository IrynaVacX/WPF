using System;
using System.Windows;

namespace WpfApp5_3_ImageBlur
{
    public partial class MainWindow : Window
    {
        private System.Windows.Media.Effects.BlurEffect fb;
        private System.Windows.Media.Effects.DropShadowEffect fd;
        public MainWindow()
        {
            InitializeComponent();
            fb = new System.Windows.Media.Effects.BlurEffect();
            fd = new System.Windows.Media.Effects.DropShadowEffect();
            sl1.Maximum = 100;
            sl2.Maximum = 100;
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            fb.Radius = sl1.Value;
            _1.Effect = fb;
        }

        private void Slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            fd.BlurRadius = sl2.Value;
            if (sl2.Value == 0)
                fd.Opacity = 0;
            else
                fd.Opacity = sl2.Value/25.0;
            r1.Effect = fd;
        }
    }
}
