using System;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Win32;

namespace WpfApp4_1_ContextMenu
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }
        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == true)
                if (f.FileName.Contains(".mp4") || f.FileName.Contains(".mp3") || f.FileName.Contains(".avi"))
                {
                    mediaElement1.Source = new Uri(f.FileName, UriKind.Absolute);
                    mediaElement1.LoadedBehavior = System.Windows.Controls.MediaState.Manual;
                    mediaElement1.UnloadedBehavior = System.Windows.Controls.MediaState.Manual;
                    mediaElement1.ScrubbingEnabled = true;
                    mediaElement1.Play();
                }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            slider1.Value = mediaElement1.Position.TotalSeconds;
        }
        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Play();
        }
        private void button__Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();
        }
        private void buttonPause_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
        }
        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement1.Position = TimeSpan.FromSeconds(slider1.Value);
        }
        private void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            slider1.Minimum = 0;
            slider1.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalSeconds;
            timer.Start();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
