using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp7_2_RectangleXY
{
    public partial class MainWindow : Window
    {
        private Point? coords;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void rect1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            coords = e.GetPosition(rect1);
            rect1.CaptureMouse();
        }
        private void rect1_MouseMove(object sender, MouseEventArgs e)
        {
            if (coords != null)
            {
                var c = e.GetPosition(this) - (Vector)coords.Value;
                Canvas.SetLeft(rect1, c.X);
                Canvas.SetTop(rect1, c.Y);
            }
        }
        private void rect1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            coords = null;
            rect1.ReleaseMouseCapture();
        }
    }
}
