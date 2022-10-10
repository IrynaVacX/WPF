using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp2_
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _TabC_Load();
            _RBut_Load();
        }
        private void _RBut_Load()
        {
            g1_3.IsChecked = true;
            g2_3.IsChecked = true;
            g3_3.IsChecked = true;
            g4_3.IsChecked = true;
            g5_3.IsChecked = true;
            g6_3.IsChecked = true;
        }
        private void _TabC_Load()
        {
            TabItem t;
            for (int i = 5; i < 18; i++)
            {
                t = new TabItem();
                t.Header = i + " пара";
                t.Margin = tabI_0.Margin;
                t.Width = tabI_0.Width;
                t.Foreground = tabI_0.Foreground;
                t.BorderBrush = tabI_0.BorderBrush;
                t.Background = tabI_0.Background;
                _TabC.Items.Add(t);
            }
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            (sender as RadioButton).Background = (sender as RadioButton).BorderBrush;
        }
        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            (sender as RadioButton).Background = _TabC.Background;
        }
        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if ((sender as Label).Foreground == _TabC.BorderBrush)
                (sender as Label).Foreground = _krest.Background;
            else
                (sender as Label).Foreground = _TabC.BorderBrush;
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            (sender as RadioButton).Background = (sender as RadioButton).Foreground;
            g1_1.IsChecked = true;
            g2_1.IsChecked = true;
            g3_1.IsChecked = true;
            g4_1.IsChecked = true;
            g5_1.IsChecked = true;
            g6_1.IsChecked = true;
        }
        private void _krest_Click(object sender, RoutedEventArgs e)
        {
            _k1.Foreground = (sender as Button).BorderBrush;
            _k2.Foreground = (sender as Button).BorderBrush;
            _k3.Foreground = (sender as Button).BorderBrush;
        }
        private void _krest2_Click(object sender, RoutedEventArgs e)
        {
            _k12.Foreground = (sender as Button).BorderBrush;
            _k22.Foreground = (sender as Button).BorderBrush;
            _k32.Foreground = (sender as Button).BorderBrush;
        }
        private void _krest3_Click(object sender, RoutedEventArgs e)
        {
            _k13.Foreground = (sender as Button).BorderBrush;
            _k23.Foreground = (sender as Button).BorderBrush;
            _k33.Foreground = (sender as Button).BorderBrush;
        }
        private void _krest4_Click(object sender, RoutedEventArgs e)
        {
            _k14.Foreground = (sender as Button).BorderBrush;
            _k24.Foreground = (sender as Button).BorderBrush;
            _k34.Foreground = (sender as Button).BorderBrush;
        }
        private void _krest5_Click(object sender, RoutedEventArgs e)
        {
            _k15.Foreground = (sender as Button).BorderBrush;
            _k25.Foreground = (sender as Button).BorderBrush;
            _k35.Foreground = (sender as Button).BorderBrush;
        }
        private void _krest6_Click(object sender, RoutedEventArgs e)
        {
            _k16.Foreground = (sender as Button).BorderBrush;
            _k26.Foreground = (sender as Button).BorderBrush;
            _k36.Foreground = (sender as Button).BorderBrush;
        }
    }
}
