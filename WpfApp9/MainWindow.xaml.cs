using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RedColor(object sender, ExecutedRoutedEventArgs e)
        {
            but1.Background = Brushes.Red;
        }
        private void GreenColor(object sender, ExecutedRoutedEventArgs e)
        {
            but1.Background = Brushes.ForestGreen;
        }
        private void BlueColor(object sender, ExecutedRoutedEventArgs e)
        {
            but1.Background = Brushes.DeepSkyBlue;
        }
        private void YellowColor(object sender, ExecutedRoutedEventArgs e)
        {
            but1.Background = Brushes.Yellow;
        }
        private void MagentaColor(object sender, ExecutedRoutedEventArgs e)
        {
            but1.Background = Brushes.Magenta;
        }
    }
    public class ColorCommands
    {
        static ColorCommands()
        {
            RedCommand = new RoutedCommand("RedCommand", typeof(ColorCommands));
            GreenCommand = new RoutedCommand("GreenCommand", typeof(ColorCommands));
            BlueCommand = new RoutedCommand("BlueCommand", typeof(ColorCommands));
            YellowCommand = new RoutedCommand("YellowCommand", typeof(ColorCommands));
            MagentaCommand = new RoutedCommand("MagentaCommand", typeof(ColorCommands));
        }
        public static RoutedCommand RedCommand { get; set; }
        public static RoutedCommand GreenCommand { get; set; }
        public static RoutedCommand BlueCommand { get; set; }
        public static RoutedCommand YellowCommand { get; set; }
        public static RoutedCommand MagentaCommand { get; set; }
    }
}
