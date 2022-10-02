using System;
using System.Windows;
using System.Windows.Threading;

namespace WpfApp5_4_Hypnosis
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        double t = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            t += 0.08;
            _h.RenderTransform = new System.Windows.Media.RotateTransform() { Angle = t };
            if (t >= 360)
                t = 0;
        }
    }
}
