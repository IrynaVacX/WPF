using System;
using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace WpfApp4_1_ContextMenu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == true)
                if (f.FileName.Contains(".mp4") || f.FileName.Contains(".mp3"))
                {
                    mediaElement1.Source = new Uri(f.FileName, UriKind.Absolute);
                    mediaElement1.LoadedBehavior = System.Windows.Controls.MediaState.Manual;
                    mediaElement1.UnloadedBehavior = System.Windows.Controls.MediaState.Manual;
                    mediaElement1.ScrubbingEnabled = true;
                    mediaElement1.Play();
                    if (mediaElement1.NaturalDuration.HasTimeSpan)
                    {
                    slider1.Maximum = (int)mediaElement1.NaturalDuration.TimeSpan.TotalSeconds;
                    slider1.Value = 0;

                    }
                }
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
            //slider1.Value = mediaElement1.Position.TotalSeconds;
            mediaElement1.Position = new TimeSpan((int)slider1.Value);
        }
    }
}
