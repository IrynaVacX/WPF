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

namespace WpfApp2_4_MyState_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _TabC_Load();
        }

        private void _TabC_Load()
        {
            TabItem t;
            for (int i = 1; i < 18; i++)
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
            RadioButton_Checked(g1_1, e);
        }
    }
}
