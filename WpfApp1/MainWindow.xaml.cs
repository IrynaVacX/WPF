using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
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
        private int i = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = $"{++i}";
            if (i == 10)
                form1.Children.Remove(button1);
        }
    }
}
